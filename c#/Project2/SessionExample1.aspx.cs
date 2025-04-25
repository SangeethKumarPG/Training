using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class SessionExample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["userName"] = TextBox1.Text;
            Session["password"] = TextBox2.Text;

            Response.Redirect("SessionExample2.aspx");
        }
    }
}