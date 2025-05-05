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
    }
}
