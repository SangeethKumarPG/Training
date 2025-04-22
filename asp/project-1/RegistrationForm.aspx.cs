using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            NameField.Text = "";
            AddressField.Text = "";
            MobileNumber.Text = "";
            EmployeeCode.Text = "";
            PasswordField.Text = "";
        }
    }
}