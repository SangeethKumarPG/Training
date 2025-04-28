using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseConnectionPrograms
{
    public partial class EmployeeUpdate : System.Web.UI.Page
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 id = Request.QueryString["Id"];
                Service service = new Service();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Employee WHERE Id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = service.GetResult(cmd);
                if (reader.Read())
                {
                    TextBox1.Text = reader.GetInt32(0).ToString();
                    TextBox2.Text = reader.GetString(1).ToString();
                    TextBox3.Text = reader.GetString(2).ToString();
                    TextBox4.Text = reader.GetInt32(3).ToString();
                    TextBox5.Text = reader.GetString(4).ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Employee SET Name=@name, Designation=@designation, Salary=@salary, Dept=@dept WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(TextBox4.Text));
            cmd.Parameters.AddWithValue("@designation", TextBox3.Text);
            cmd.Parameters.AddWithValue("@dept",TextBox5.Text);

            service.ExecuteQuery(cmd);

            Response.Redirect("DataListExample.aspx");
        }
    }
}