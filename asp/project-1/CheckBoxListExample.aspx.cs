using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class CheckBoxListExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dictionary<string, string> checkBoxItems = new Dictionary<string, string>();
                checkBoxItems.Add("SP", "SP");
                checkBoxItems.Add("BLU", "BLU");
                checkBoxItems.Add("Windmill", "Windmill");

                foreach (var item in checkBoxItems)
                {
                    CheckBoxList1.Items.Add(new ListItem(item.Value, item.Key));
                }

            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            List<string> list = new List<string>();
            foreach(ListItem item in CheckBoxList1.Items){
                if (item.Selected)
                {
                    list.Add(item.Value);
                }
            }

            // string.Join(" ", list); Alternatively.
            foreach(var item in list)
            {
                Label1.Text += "<br/>" + item;
            }

            Response.Write(string.Join(" ", list));
        }
    }
}