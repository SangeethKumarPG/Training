using Business.Services;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;


namespace ExampleAPI.Controllers
{
    //[ApiController]
    //[Route("api/v1/[controller]")]
    public class EmployeeController : Controller 
    {
        private readonly EmployeeRepo _employeeRepo;
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeRepo employeeRepo, EmployeeService employeeService)
        {
            _employeeRepo = employeeRepo;
            _employeeService = employeeService;
        }

        [HttpGet("GetName/{name}", Name ="GetName")]
        public Task<dynamic> GetName([FromRoute]string name){
            var res = _employeeService.GetNameService(name);
            return res;
        }

        [HttpGet("GetAllEmp", Name ="GetAllEmployees")]
        public Task<IActionResult> GetAllEmployees()
        {
            return _employeeService.GetAllEmployeeDetails();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
