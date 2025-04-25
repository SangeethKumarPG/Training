using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class ValuePassingTo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.QueryString["n1"];
            string password = Request.QueryString["n2"];
            Label1.Text = "User name is : " + userName + "<br/>" + "Password is : " + password;
        }
    }
}