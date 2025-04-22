using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class MultiplicationTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DisplayTable_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(InputNumber.Text);
            for(int i=1; i<=10; i++)
            {
                Result.Text += $"{i} x {number} = {number * i}<br/>";
            }
        }
    }
}