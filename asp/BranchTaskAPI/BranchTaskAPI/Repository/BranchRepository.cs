using BranchTaskAPI.DataAccess;
using BranchTaskAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace BranchTaskAPI.Repository
{
    public class BranchRepository : ControllerBase
    {
        private Branch _branch;
        private DataContext _dataContext;

        public BranchRepository(Branch branch, DataContext dataContext)
        {
            _branch = branch;
            _dataContext = dataContext;
        }

        public async Task<IActionResult> GetAllBranches()
        {
            var cmd = "SELECT * FROM Branch";
            var branches = new List<Branch>();
            using (var connection = _dataContext.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                using (var reader = await command.ExecuteReaderAsync())
                {

                    while (await reader.ReadAsync())
                    {
                        var branch = new Branch
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            brname = reader.GetString(reader.GetOrdinal("brname")),
                            head = reader.GetString(reader.GetOrdinal("head")),
                            noofemployees = reader.GetInt32(reader.GetOrdinal("noofemployees"))
                        };
                        branches.Add(branch);
                    }
                }
            }
            return Ok(branches);
        }

        public async Task<IActionResult> GetBranchByName(string name)
        {
            var cmd = "SELECT Id, brname FROM Branch WHERE brname LIKE @name";
            var branches = new List<Branch>();
            using (var connection = _dataContext.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                command.Parameters.AddWithValue("@name", "%" + name + "%");
                using (var reader = await command.ExecuteReaderAsync())
                {

                    while (await reader.ReadAsync())
                    {
                        var branch = new Branch
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            brname = reader.GetString(reader.GetOrdinal("brname"))
                        };
                        branches.Add(branch);
                    }
                }
            }
            return Ok(branches);
        }

        public async Task<IActionResult> GetBranchById(string branchId)
        {
            int branchIdInt = Convert.ToInt32(branchId);
            var cmd = "SELECT * FROM Branch WHERE Id = @Id";
            var branches = new List<Branch>();
            using (var connection = _dataContext.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                command.Parameters.AddWithValue("@Id", branchIdInt);
                using (var reader = await command.ExecuteReaderAsync())
                {

                    while (await reader.ReadAsync())
                    {
                        var branch = new Branch
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            brname = reader.GetString(reader.GetOrdinal("brname")),
                            head = reader.GetString(reader.GetOrdinal("head")),
                            noofemployees = reader.GetInt32(reader.GetOrdinal("noofemployees"))
                        };
                        branches.Add(branch);
                    }
                }
            }

            return Ok(branches);
        }


    }
}
