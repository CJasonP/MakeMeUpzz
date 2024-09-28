using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace MakeMeUpzz.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Session["userid"].ToString());
            string userEmail = tbEmail.Text;
            string userName = tbUsername.Text;
            string userGender = ddlGender.Text;
            string dobString = tbDateOfBirth.Text;

            DateTime dob;
            if (!DateTime.TryParseExact(dobString, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
            {
                lblProfileMessage.Text = "Invalid date format. Please use dd-MM-yyyy.";
                lblProfileMessage.Visible = true;
                return;
            }

            UpdateProfileController.updateProfile(userEmail, userName, userGender, id, dob);
            Response.Redirect("ViewProfile.aspx");
        }
    }
}