using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Context
{
    public class DataContext:DbContext
    {
        private readonly string _connectionString;

        public DataContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SQLConnection");
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
