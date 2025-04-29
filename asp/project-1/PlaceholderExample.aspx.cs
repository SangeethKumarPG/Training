using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class PlaceholderExample : System.Web.UI.Page
    {
        public Label textLabel = new Label();
        public TextBox textBox = new TextBox();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNAddControl_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Control added";
            PlaceHolder1.Controls.Add(textLabel);
            PlaceHolder1.Controls.Add(textBox);
        }

        protected void BTNRemoveControl_Click(object sender, EventArgs e)
        {
            PlaceHolder1.Controls.Remove(textLabel);
            PlaceHolder1.Controls.Remove(textBox);
        }
    }
}