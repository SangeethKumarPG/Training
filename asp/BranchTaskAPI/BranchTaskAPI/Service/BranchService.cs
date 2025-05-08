using BranchTaskAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BranchTaskAPI.Service
{
    public class BranchService
    {
        private BranchRepository _branchRepository;
        public BranchService(BranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public async Task<IActionResult> GetAllBranches()
        {
            return await _branchRepository.GetAllBranches();
        }

        public async Task<IActionResult> GetBranchesByName(string name)
        {
            return await _branchRepository.GetBranchByName(name);
        }

        public async Task<IActionResult> GetBranchById(string id)
        {
            return await _branchRepository.GetBranchById(id);
        }
    }
}
