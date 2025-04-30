using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrainingApp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            SqlDataReader sqlDataReader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText="SELECT UserName, Password, Position FROM [User] WHERE UserName=@username AND Password=@password;";
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);
            sqlDataReader = service.GetQueryResult(cmd);
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read()) { 
                    string position = sqlDataReader.GetString(2);
                    if(position.Trim() == "Trainer")
                    {
                        Response.Redirect("TrainerDashboard.aspx");
                    }
                    else
                    {
                        
                    }
                }
            }
            else
            {
                
            }
        }
    }
}