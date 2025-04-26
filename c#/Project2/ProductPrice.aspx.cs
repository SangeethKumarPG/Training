using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class ProductPrice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Panel2.Visible = false;
                Panel3.Visible = false;
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue != "Select")
            {
                Panel2.Visible = true;
                if(DropDownList1.SelectedValue == "ProductA")
                {
                    TextBox1.Text = 3000.ToString();
                } else if(DropDownList1.SelectedValue == "ProductB")
                {
                    TextBox1.Text = 25.50.ToString();
                }else if (DropDownList1.SelectedValue == "ProductC")
                {
                    TextBox1.Text = 45.25.ToString();
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(TextBox1.Text);
            double quantity = Convert.ToDouble(TextBox2.Text);
            Panel3.Visible = true;
            TextBox3.Text = (Math.Round((price * quantity), 2)).ToString();
        }
    }
}