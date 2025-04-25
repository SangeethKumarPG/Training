using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class StudentMarks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["studentName"] = TextBox1.Text;
            Session["mark1"] = TextBox2.Text;
            Session["mark2"] = TextBox3.Text;
            Session["mark3"] = TextBox4.Text;
            Session["mark4"] = TextBox5.Text;

            Response.Redirect("StudentAvgMarks.aspx");

        }
    }
}