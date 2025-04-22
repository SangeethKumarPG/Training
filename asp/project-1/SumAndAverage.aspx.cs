using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class SumAndAverage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int physicsMarks = int.Parse(Physics.Text);
            int chemistryMarks = int.Parse(Chemistry.Text);
            int biologyMarks = int.Parse(Biology.Text);
            int mathsMarks = int.Parse(Maths.Text);
            int englishMarks = int.Parse(English.Text);

            int totalMarks = physicsMarks + chemistryMarks + biologyMarks + englishMarks + mathsMarks;
            double averageMarks = totalMarks / 5;

            string resultText = $"Sum is : {totalMarks}, Average is :{averageMarks}";

            Result.Text = resultText;
        }
    }
}