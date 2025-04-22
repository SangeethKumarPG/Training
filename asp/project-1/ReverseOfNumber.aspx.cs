using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace project_1
{
    public partial class ReverseOfNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Reverse_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(InputNumber.Text);
            int digit = 0;
            int sum = 0;
            while (number > 0) {
                digit = number % 10;
                number = number / 10;
                sum = sum * 10 + digit;
            }
            Result.Text = sum.ToString();
        }
    }
}