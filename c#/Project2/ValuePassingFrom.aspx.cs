using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class ValuePassingFrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = TxtBoxUserName.Text;
            string userPassword = TxtBoxPassword.Text;

            Response.Redirect("ValuePassingTo.aspx?n1=" + userName + "&n2=" + userPassword);
        }
    }
}