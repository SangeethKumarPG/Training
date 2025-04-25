using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class StudentAvgMarks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["studentName"].ToString();
            double mark1 = Convert.ToDouble(Session["mark1"].ToString());
            double mark2 = Convert.ToDouble(Session["mark2"].ToString());
            double mark3 = Convert.ToDouble(Session["mark3"].ToString());
            double mark4 = Convert.ToDouble(Session["mark4"].ToString());

            double totalMarks = mark1 + mark2 + mark3 + mark4;
            double averageMarks = (totalMarks / 4);

            Label2.Text = Math.Round(totalMarks, 2).ToString();
            Label3.Text = Math.Round(averageMarks, 2) + "%";
        }
    }
}