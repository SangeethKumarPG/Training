using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    public class EmployeeController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
