using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class DropDownExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>()
            {
                {"Test User","1234"},
                { "New User","1235"},
                {"Sample User","1236"  }
            };

            foreach (var employee in myDictionary)
            {
                DDLEmployee.Items.Add(new ListItem(employee.Key, employee.Value));
            }
        }

        protected void BtnEmpSelect_Click(object sender, EventArgs e)
        {
            if(DDLEmployee.SelectedValue == "-1")
            {
                SelectResultLabel.Text = "Please Select an Employee";
            }
            else
            {
                SelectResultLabel.Text = $"Employee name : {DDLEmployee.SelectedItem}, EmployeeCode : {DDLEmployee.SelectedValue}";
            }
        }
    }
}