using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseConnectionPrograms
{
    public partial class EmployeeGridFetch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service service = new Service();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Employee;";
            SqlDataReader reader = service.GetResult(cmd);
            GridView1.DataSource = reader;
            GridView1.DataBind();

        }
    }
}