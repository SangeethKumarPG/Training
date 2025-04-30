using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrainingApp
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "1")
            {
                Dictionary<string,string> subjects = new Dictionary<string,string>();
                subjects.Add("html", "HTML");
                subjects.Add("css", "CSS");
                subjects.Add("js", "JavaScript");
                subjects.Add("angular", "Angular");
                subjects.Add("asp.net", "ASP.NET");
                Label1.Visible = true;
                CheckBoxList1.Visible = true;
                foreach (var subject in subjects) {
                    CheckBoxList1.Items.Add(new ListItem(subject.Value, subject.Key));
                }

            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> selectedSubjects = new List<string>();
            foreach(ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    selectedSubjects.Add(item.Value);
                }
            }

            Service service = new Service();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO [User] VALUES(@id,@username, @password,@position,@skills);";
            string position = DropDownList1.SelectedValue == "1" ? "Trainer" : DropDownList1.SelectedValue !="-1" ? "Trainee":"Invalid";
            if (position != "Invalid")
            {
                sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox3.Text));
                sqlCommand.Parameters.AddWithValue("@username", TextBox1.Text);
                sqlCommand.Parameters.AddWithValue("@password", TxtBoxPassword.Text);
                sqlCommand.Parameters.AddWithValue("@position", position);
                string skills = string.Join(",",selectedSubjects);
                sqlCommand.Parameters.AddWithValue("@skills", skills);
                service.ExecuteQuery(sqlCommand);
            }
            
            foreach (var subject in selectedSubjects) {
                SqlCommand checkCommand = new SqlCommand();
                checkCommand.CommandText = "SELECT * FROM [Subject] WHERE Id=@id";
                checkCommand.Parameters.AddWithValue("@id", subject);
                SqlDataReader checkSubjectExistReader = service.GetQueryResult(checkCommand);
                if (!checkSubjectExistReader.HasRows)
                {
                    SqlCommand sqlCommand1 = new SqlCommand();
                    sqlCommand1.CommandText = "INSERT INTO [Subject] VALUES(@id, @subject,@trainer);";
                    sqlCommand1.Parameters.AddWithValue("@id", subject);
                    sqlCommand1.Parameters.AddWithValue("@subject", subject);
                    sqlCommand1.Parameters.AddWithValue("@trainer", Convert.ToInt32(TextBox3.Text));
                    service.ExecuteQuery(sqlCommand1);
                }
            }

            
        }
    }
}