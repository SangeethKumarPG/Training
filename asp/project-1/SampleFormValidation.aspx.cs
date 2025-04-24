using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class SampleFormValidation : System.Web.UI.Page
    {

        protected Boolean ValidateForm()
        {
            if(DDLDistrict.SelectedItem.Value=="DST")
            {
                DistrictError.Visible = true;
                DistrictError.Text = "Please select district";
                return false;
            }
            else
            {
                DistrictError.Visible = false;
            }

            if (TxtBoxAddress.Text == " " || TxtBoxAddress.Text.Length == 0)
            {
                AddressError.Visible = true;
                AddressError.Text = "Address is required";
                return false;
            }
            else
            {
                AddressError.Visible = false;
            }

            if (RBLGender.SelectedItem == null)
            {
                GenderError.Visible = true;
                GenderError.Text = "Please Select a gender";
                return false;
            }
            else
            {
                GenderError.Visible = false;
            }

            if (DDLQualification.SelectedItem.Value == "Qual")
            {
                QualificationError.Visible = true;
                QualificationError.Text = "Please choose a qualification";
                return false;
            }
            else
            {
                QualificationError.Visible = false;
            }

            if (TextBoxName.Text.Length == 0 || TextBoxName.Text == " ")
            {
                NameError.Visible = true;
                NameError.Text = "Please provide a name";
                return false;
            }
            else { 
                NameError.Visible = false;
            }

                return true;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dictionary<string, string> qualificationList = new Dictionary<string, string>();
                qualificationList.Add("Qual", "Select Qualification");
                qualificationList.Add("10th", "Secondary");
                qualificationList.Add("12th", "Higher Secondary");
                qualificationList.Add("Degree", "Graduation");
                qualificationList.Add("PG", "Post Graduation");

                foreach (var item in qualificationList)
                {
                    DDLQualification.Items.Add(new ListItem(item.Value, item.Key));
                }

                Dictionary<string, string> districtList = new Dictionary<string, string>();
                districtList.Add("DST", "Select District");
                districtList.Add("TVM", "Thiruvanathapuram");
                districtList.Add("KLM", "Kollam");
                districtList.Add("PTA", "Pathanamthitta");
                districtList.Add("KTM", "Kottayam");
                districtList.Add("APA", "Alappuzha");
                districtList.Add("EKM", "Eranakulam");
                districtList.Add("IDK", "Idukki");
                districtList.Add("TSR", "Thrissur");
                districtList.Add("MPM", "Malappuram");
                districtList.Add("PKD", "Palakkad");
                districtList.Add("KZD", "Kozhikode");
                districtList.Add("WYD", "Wayanad");
                districtList.Add("KNR", "Kannur");
                districtList.Add("KSR", "Kazargod");

                foreach (var item in districtList) {
                    DDLDistrict.Items.Add(new ListItem(item.Value, item.Key));
                }

            }

        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Response.Write("<script>window.alert('form submitted successfully!');</script>");
            }
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {
            DDLDistrict.SelectedValue = "DST";
            DDLQualification.SelectedValue = "Qual";
            TextBoxName.Text = "";
            RBLGender.SelectedValue = null;
            TxtBoxAddress.Text = "";

        }
    }
}