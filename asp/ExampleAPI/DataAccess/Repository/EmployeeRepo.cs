using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DataAccess.Repository
{
    public class EmployeeRepo : ControllerBase
    {
        private DataContext _context;
        private Employee _model;
        public EmployeeRepo(Employee model, DataContext context)
        {
            _context = context;
            _model = model;
        }
        public async Task<dynamic> GetNameRepo(string name)
        {
            var res = "My name is " + name;
            return res;
        }

        public async Task<IActionResult> GetAllEmployeeDetails()
        {
            var cmd = "SELECT * FROM Employee";
            var employees = new List<Employee>();
            using (var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var employee = new Employee
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Designation = reader.GetString(reader.GetOrdinal("Designation")),
                            Department = reader.GetString(reader.GetOrdinal("Dept"))
                        };

                        employees.Add(employee);
                    }
                }
            }
            return Ok(employees);
        }
    }
}
