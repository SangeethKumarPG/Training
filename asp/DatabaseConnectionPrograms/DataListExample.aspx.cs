using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseConnectionPrograms
{
    public partial class DataListExample : System.Web.UI.Page
    {
        protected void fetchAndBindData()
        {
            Service service = new Service();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Employee";
            SqlDataReader reader = service.GetResult(cmd);
            DataList1.DataSource = reader;
            DataList1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fetchAndBindData();
            }
           
        }

        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "Remove")
            {
                int recordToRemove = Convert.ToInt32(e.CommandArgument);
                Service service = new Service();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM Employee WHERE Id=@id";
                cmd.Parameters.AddWithValue("@id", recordToRemove);

                service.ExecuteQuery(cmd);
                fetchAndBindData();
            }


        }
    }
}