using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) 
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            string userName = "";
            string userEmail = "";
            string userGender = "";
            string userDOB = "";
            Boolean user = ProfileController.checkCurr(Int32.Parse(Session["userid"].ToString()), out userName, out userEmail, out userGender, out userDOB);

            lblName.Text = userName;
            lblEmail.Text = userEmail;
            lblGender.Text = userGender;
            lblDOB.Text = userDOB;  
        }
    }
}