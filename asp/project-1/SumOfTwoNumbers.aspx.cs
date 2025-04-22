using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class SumOfTwoNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            int firstNum = int.Parse(FirstNumber.Text);
            int secondNum = int.Parse(SecondNumber.Text);
            int sumOfNumbers = firstNum + secondNum;
            Sum.Text = sumOfNumbers.ToString();
        }

        protected void SubtractButton_Click(Object sender, EventArgs e)
        {
            int firstNum = int.Parse(FirstNumber.Text);
            int secondNum = int.Parse(SecondNumber.Text);
            int result = firstNum - secondNum;
            Sum.Text = result.ToString();
        }

        protected void ResetButton_Click(Object sender, EventArgs e)
        {
            FirstNumber.Text = "";
            SecondNumber.Text = "";
            Sum.Text = "";
        }

        protected void MultiplyButton_Click(Object sender, EventArgs e)
        {
            int firstNum = int.Parse(FirstNumber.Text);
            int secondNum = int.Parse(SecondNumber.Text);
            int result = firstNum * secondNum;
            Sum.Text = result.ToString();
        }

        protected void DivideButton_Click(Object sender, EventArgs e)
        {
            int firstNum = int.Parse(FirstNumber.Text);
            int secondNum = int.Parse(SecondNumber.Text);
            int result = firstNum / secondNum;
            Sum.Text = result.ToString();
        }

    }
}