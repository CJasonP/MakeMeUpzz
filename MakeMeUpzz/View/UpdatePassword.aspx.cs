using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class UpdatePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string userPassword = "";
            Boolean temp = UpdatePasswordController.checkExistUserId(Int32.Parse(Session["userid"].ToString()), out userPassword);

            if (tbOldPassword.Text == tbNewPassword.Text && userPassword == tbOldPassword.Text)
            {
                string newPassword = tbNewPassword.Text;
                int id = Int32.Parse(Session["userid"].ToString());
                UpdatePasswordController.updatePassword(id, newPassword);
                Response.Redirect("ViewProfile.aspx");
            }
            else
            {
                if (tbOldPassword.Text != userPassword)
                {
                    lblPasswordMessage.Text = "The old password you entered is incorrect.";
                }
                else if (tbOldPassword.Text == tbNewPassword.Text)
                {
                    lblPasswordMessage.Text = "The new password cannot be the same as the old password.";
                }
            }
        }
    }
}