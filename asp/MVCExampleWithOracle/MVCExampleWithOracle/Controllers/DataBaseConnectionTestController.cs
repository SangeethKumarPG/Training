using Microsoft.AspNetCore.Mvc;
using MVCExampleWithOracle.DataAccess;
using Dapper;
using System.Data;
using MVCExampleWithOracle.Model;
using Oracle.ManagedDataAccess.Client;

namespace MVCExampleWithOracle.Controllers
{
    public class DataBaseConnectionTestController : Controller
    {
        private DataContext _dataContext; 
        public DataBaseConnectionTestController(DataContext dataContext) {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/api/v1/GetAllEmployees", Name ="GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            try {
                using (IDbConnection dbconnection = _dataContext.CreateConnection())
                {
                    dbconnection.Open();
                    var employees = await dbconnection.QueryAsync<Employee>("SELECT * from emp");
                    return Ok(employees);
                }
            }catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message} - {ex.InnerException?.Message}");
            }
            
        }

        [HttpPost("/api/v1/AddDept", Name="AddDept")]
        public async Task<IActionResult> AddDepartment([FromBody]DepartmentDTO dto)
        {
            if (dto == null) {
                return BadRequest("Department data is required");
            }
            try {
                using (IDbConnection connection = _dataContext.CreateConnection()) {
                    await connection.Open();
                    using(var command = new OracleCommand("ADD_DEPT", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("IN_DEPT_NO", OracleDbType.Int32).Value = dto.deptno;
                        command.Parameters.Add("IN_DEPT_NAME", OracleDbType.Varchar2).Value = dto.dname;
                        command.Parameters.Add("IN_LOC", OracleDbType.Varchar2).Value = dto.loc;

                        await command.ExecuteNonQuery();

                    }
                }
                return Ok("Department added successfully!");
            } catch (Exception ex) {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

    }
}
