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

            
    }
}
