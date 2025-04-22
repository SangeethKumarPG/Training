using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class MinorOrMajor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void CheckMinorOrMajor_Click(object sender, EventArgs e)
        {
            int age = 0;
            bool isNumber = int.TryParse(Age.Text, out age);

            if (isNumber)
            {
                if (age >= 18)
                {
                    ResultLabel.Text = "Major";
                }
                else
                {
                    ResultLabel.Text = "Minor";
                }
            }
        }
    }
}