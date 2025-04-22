using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class StudentGradeCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int physicsMarks = int.Parse(Physics.Text);
            int chemistryMarks = int.Parse(Chemistry.Text);
            int biologyMarks = int.Parse(Biology.Text);
            int mathsMarks = int.Parse(Maths.Text);
            int englishMarks = int.Parse(English.Text);

            int totalMarks = physicsMarks + chemistryMarks + biologyMarks + englishMarks + mathsMarks;
            double averageMarks = totalMarks / 5;

            NameLabel.Text = "Name : " + Name.Text;
            double percentage = (totalMarks / 500.0) * 100;
            string grade = null;
            if(percentage >= 90)
            {
                Grade.Text = "A+";
            }else if(percentage < 90 && percentage >= 80)
            {
                Grade.Text = "B+";
            }else if(percentage < 80 && percentage >=70)
            {
                Grade.Text = "C+";
            } else if(percentage < 70 && percentage >= 60)
            {
                Grade.Text = "D+";
            }
            else
            {
                Grade.Text = "FAIL";
            }

            Percentage.Text = "Percentage : " + percentage;
            Total.Text = "Total : " + totalMarks;
        }
    }
}