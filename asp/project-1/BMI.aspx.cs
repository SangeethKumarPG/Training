using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class BMI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(Height.Text);
            double weight = double.Parse(Weight.Text);
            double heightInMetres = height / 100.0;

            double bodyMassIndex = weight / (heightInMetres * heightInMetres);

            Result.Text = bodyMassIndex.ToString();
        }
    }
}