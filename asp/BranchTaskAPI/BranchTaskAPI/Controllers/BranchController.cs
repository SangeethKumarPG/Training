using Microsoft.AspNetCore.Mvc;
using BranchTaskAPI.Service;

namespace BranchTaskAPI.Controllers
{
    public class BranchController : Controller
    {
        private BranchService _service;
        public BranchController(BranchService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("api/v1/GetAllBranches", Name = "GetAllBranches")]
        public async Task<IActionResult> GetAllBranches()
        {
            return await _service.GetAllBranches();
        }

        [HttpGet("api/v1/GetBranchByName/{name}", Name ="GetBranchByName")]
        public async Task<IActionResult> GetBranchByName([FromRoute]string name)
        {
            return await _service.GetBranchesByName(name);
        }

        [HttpGet("api/v1/GetBranchById/{id}", Name = "GetBranchById")]
        public async Task<IActionResult> GetBranchById([FromRoute] string id)
        {
            return await _service.GetBranchById(id);
        }

    }
}
