using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class Panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PanelClick1(object sender, EventArgs e)
        {
            PanelContainer.Visible = true;
            Panel3.Visible = false;

        }

        protected void Panel2_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            PanelContainer.Visible = false;
        }

        protected void CalcAmstrongButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(AmstrongInput.Text);
            int copyOfNumber = number;
            int digit = 0;
            int sum = 0;
            int digitCount = Convert.ToString(number).Length;
            while (number > 0) {
                digit = number % 10;
                number = number / 10;
                sum = (int)(sum + Math.Pow(digit, digitCount));
            }
            if(sum == copyOfNumber)
            {
                AmstrongResult.Text = "Number is amstrong";
            }
            else
            {
                AmstrongResult.Text = "Number is not amstrong";
            }
        }

        protected void AmstrongRangeButton_Click(object sender, EventArgs e)
        {
            int lowerLimit = Convert.ToInt32(LowerLimit.Text);
            int upperLimit = Convert.ToInt32(UpperLimit.Text);

            for (int i = lowerLimit; i <= upperLimit; i++) {
                int copyOfNumber = i;
                int number = i;
                int digit = 0;
                int sum = 0;
                int digitCount = Convert.ToString(i).Length;
                while(number > 0)
                {
                    digit = number % 10;
                    number /= 10;
                    sum = (int)(sum + Math.Pow(digit, digitCount));
                }
                if(sum == copyOfNumber)
                {
                    AmstrongRange.Text += " " + i + ",";
                }
            }
        }
    }
}