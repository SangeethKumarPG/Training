using System.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;

namespace MVCExampleWithOracle.DataAccess
{
    public class DataContext:DbContext
    {
        private readonly string _connectionString;
        public DataContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OracleDbConnection");
        }

        public IDbConnection CreateConnection() {
            return new OracleConnection(_connectionString);
        }
    }
}
