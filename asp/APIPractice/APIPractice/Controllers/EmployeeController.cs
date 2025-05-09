using APIPractice.Models;
using APIPractice.Service;
using Microsoft.AspNetCore.Mvc;

namespace APIPractice.Controllers
{
    public class EmployeeController
    {
        private EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService) { 
            _employeeService = employeeService;
        }

        [HttpGet("api/v1/GetAllEmployees", Name ="GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployeesList()
        {
            return await _employeeService.GetAllEmployeesService();
        }

        [HttpGet("api/v1/SearchEmployeesByName/{name}", Name ="SearchEmployees")]
        public async Task<IActionResult> SearchEmployeeByName([FromRoute]string name)
        {
            return await _employeeService.GetEmployeesByName(name);
        }

        [HttpGet("api/v1/SearchEmployeesById/{id}", Name="SearchEmployeeById")]
        public async Task<IActionResult> SearchEmployeeById([FromRoute]string id)
        {
            return await _employeeService.SearchEmployeeById(id);
        }

        [HttpPost("api/v1/InsertNewEmployee", Name = "InsertEmployee")]
        public async Task<IActionResult> InsertNewEmployee([FromBody]Employee employee)
        {
            return await _employeeService.InsertNewEmployee(employee);
        }
    }
}
