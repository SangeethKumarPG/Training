using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class PassOrFail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            int marks = 0;
            bool isNumber = int.TryParse(MarkTextBox.Text, out marks);
            if (isNumber) { 
                
                if(marks > 30)
                {
                    ResultLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
                    ResultLabel.Text = "Hi " + name + " you have passed!";
                }
                else
                {
                    ResultLabel.ForeColor = System.Drawing.Color.Red;
                    ResultLabel.Text = "Sorry " + name + " you have failed!";
                }
            }
        }
    }
}