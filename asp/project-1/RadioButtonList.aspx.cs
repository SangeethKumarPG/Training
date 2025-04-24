using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class RadioButtonList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("0", "Female");
                dictionary.Add("1", "Male");
                dictionary.Add("9", "Other");

                foreach (var gender in dictionary)
                {
                    RadioButtonList1.Items.Add(new ListItem(gender.Value, gender.Key));
                }
            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = $"You have selected : {RBLGender.SelectedItem}";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Text = RadioButtonList1.SelectedItem.Text;
        }
    }
}