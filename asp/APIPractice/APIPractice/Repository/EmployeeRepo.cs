using APIPractice.Context;
using APIPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APIPractice.Repository
{
    public class EmployeeRepo : ControllerBase
    {
        private DataContext _context;
        private Employee _employee;
        public EmployeeRepo(DataContext context, Employee employee) { 
            _context = context;
            _employee = employee;
        }

        public async Task<IActionResult> GetAllEmployees()
        {
            var cmd = "SELECT * FROM Employee";
            var employees = new List<Employee>();
            using (var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (await reader.ReadAsync())
                    {
                        var employee = new Employee
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Designation = reader.GetString(reader.GetOrdinal("Designation")),
                            Dept = reader.GetString(reader.GetOrdinal("Dept"))
                        };
                        employees.Add(employee);
                    }
                }
            }
            return Ok(employees);
        }

        public async Task<IActionResult> SearchEmployeesByName(string name)
        {
            var cmd = "SELECT Id, Name FROM Employee WHERE Name LIKE @name";
            var employees = new List<Employee>();
            using(var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                command.Parameters.AddWithValue("@name", "%" + name + "%");
                using (var reader = command.ExecuteReader())
                {
                    while(await reader.ReadAsync())
                    {
                        var employee = new Employee
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name"))
                        };
                        employees.Add(employee);
                    }
                }
            }
            return Ok(employees);
        }

        public async Task<IActionResult> SearchEmployeeById(string id)
        {
            var userId = Convert.ToInt32(id);
            var cmd = "SELECT * FROM Employee WHERE Id = @Id";
            var employees = new List<Employee>();
            using(var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                command.Parameters.AddWithValue("@Id", userId);
                using(var reader = command.ExecuteReader())
                {
                    while(await reader.ReadAsync())
                    {
                        var employee = new Employee
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Designation = reader.GetString(reader.GetOrdinal("Designation")),
                            Dept = reader.GetString(reader.GetOrdinal("Dept"))
                        };
                        employees.Add(employee);
                    }

                }
            }
            return Ok(employees);
        }

        public async Task<IActionResult> InsertNewEmployee(Employee employee)
        {
            if (employee == null || employee.Id == 0 || string.IsNullOrWhiteSpace(employee.Name)) {
                return BadRequest("Invalid Employee Data");
            }
            var cmd = "INSERT INTO Employee(Id,Name,Designation,Dept) VALUES (@id,@name,@designation, @dept);";
            using(var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                var command = new SqlCommand(cmd, connection);
                command.Parameters.AddWithValue("@id", employee.Id);
                command.Parameters.AddWithValue("@name", employee.Name);
                command.Parameters.AddWithValue("@designation", employee.Designation);
                command.Parameters.AddWithValue("@dept", employee.Dept);
                var queryOutput = await command.ExecuteNonQueryAsync();
                if(queryOutput > 0)
                {
                    return Ok(employee.Id);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }   
            }
        }
    }
}
