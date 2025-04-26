using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseConnectionPrograms
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service service = new Service();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO student VALUES(@id_value,@name_value,@age_value)";
            cmd.Parameters.AddWithValue("@id_value",int.Parse(TxtBoxID.Text));
            cmd.Parameters.AddWithValue("@name_value",TxtBoxName.Text);
            cmd.Parameters.AddWithValue("@age_value", int.Parse(TxtBoxID.Text));

            service.ExecuteQuery(cmd);
        }
    }
}