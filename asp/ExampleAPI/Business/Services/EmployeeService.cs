using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Business.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepo _employeeRepo;

        public EmployeeService(EmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<dynamic> GetNameService(string name)
        {
            var res = await _employeeRepo.GetNameRepo(name);
            return res;
        }

        public async Task<IActionResult> GetAllEmployeeDetails()
        {
            var result = await _employeeRepo.GetAllEmployeeDetails();
            return result;
        }

        
    }
}
