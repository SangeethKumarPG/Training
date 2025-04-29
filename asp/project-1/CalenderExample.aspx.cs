using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class CalenderExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string datetime = Calendar1.SelectedDate.ToString();
            string[] dateTimeArray = datetime.Split(' ');
            //0th index gives the date
            // 1st index gives the time
            Label1.Text = dateTimeArray[0];
        }
    }
}