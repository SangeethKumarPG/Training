using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                string path = Server.MapPath("~/uploads/" + fileName);
                FileUpload1.SaveAs(path);
                Label1.Text = "File Upload Success!!!";
            }
            else
            {
                Label1.Text = "Please select a file to upload!";
            }
        }
    }
}