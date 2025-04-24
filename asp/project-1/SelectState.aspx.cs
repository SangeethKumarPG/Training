using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class SelectState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DDLState_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DDLState.SelectedValue == "Kerala")
            {
                DDLDistrict.Items.Clear();
                Dictionary<string, string> districts = new Dictionary<string, string>();
                districts.Add("Malappuram", "Malappuram");
                districts.Add("Palakkad", "Palakkad");
                districts.Add("Thrissur", "Thrissur");
                foreach (var district in districts)
                {
                    DDLDistrict.Items.Add(new ListItem(district.Key, district.Value));
                }
            }
            else if (DDLState.SelectedValue == "Tamilnadu")
            {
                DDLDistrict.Items.Clear();
                Dictionary<string, string> districts = new Dictionary<string, string>();
                districts.Add("Chennai", "Chennai");
                districts.Add("Coimbatore", "Coimbatore");
                districts.Add("Nagercoil", "Nagercoil");
                foreach (var district in districts)
                {
                    DDLDistrict.Items.Add(new ListItem(district.Key, district.Value));
                }
            }
            else if (DDLState.SelectedValue == "Karnataka")
            {
                DDLDistrict.Items.Clear();
                Dictionary<string, string> districts = new Dictionary<string, string>();
                districts.Add("Bangalore", "Bangalore");
                districts.Add("Kolar", "Kolar");
                districts.Add("Shirur", "Shirur");
                foreach (var district in districts)
                {
                    DDLDistrict.Items.Add(new ListItem(district.Key, district.Value));
                }
            }
            else
            {
                DDLDistrict.Items.Clear();
                DDLDistrict.Items.Add(new ListItem("Select a state", "select a state"));
            }
        }
    }
}