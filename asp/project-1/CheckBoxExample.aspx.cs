using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class CheckBoxExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string outputText = "";
            if (CheckBox1.Checked)
            {
                outputText += " Option 1 Checked";
            }
            if (CheckBox2.Checked) {
                outputText += " Option 2 Checked";
            }
            if (CheckBox3.Checked) {
                outputText += " Option 3 Checked";
            }
            Label1.Text = outputText;
        }
    }
}