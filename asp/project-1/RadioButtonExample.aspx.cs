using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class RadioButtonExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RBTMale.Checked)
            {
                Label1.Text = "You selected Male";
            }
            else if (RBTFemale.Checked)
            {
                Label1.Text = "You Selected Female";
            }
            else if (RBTOther.Checked)
            {
                Label1.Text = "You selected other";
            }
            else
            {
                Label1.Text = "Please choose a gender"; 
            }
        }
    }
}