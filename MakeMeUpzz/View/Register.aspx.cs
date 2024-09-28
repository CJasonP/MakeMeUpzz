using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string email = registerEmailBox.Text;
            string name = registerNameBox.Text;
            string password = registerPasswordBox.Text;
            string confirm = registerConfirmPasswordBox.Text;
            string gender = genderListRadioButton.SelectedValue;
            string dobString = tbDOB.Text;

            DateTime dob;
            if (!DateTime.TryParseExact(dobString, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
            {
                errorMessage.Text = "Invalid date format. Please use dd-MM-yyyy.";
                errorMessage.Visible = true;
                return;
            }

            string error;
            bool isRegistered = RegisterController.registerComplete(email, name, password, confirm, gender, dob, out error);

            if (isRegistered)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                errorMessage.Text = error;
                errorMessage.Visible = true;
            }

        }
    }
}