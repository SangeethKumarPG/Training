using APIPractice.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIPractice.Service
{
    public class EmployeeService
    {
        private EmployeeRepo _employeeRepo;
        public EmployeeService(EmployeeRepo employeeRepo) { 
            _employeeRepo = employeeRepo;
        }

        public async Task<IActionResult> GetAllEmployeesService()
        {
            return await _employeeRepo.GetAllEmployees();
        }
    }
}
