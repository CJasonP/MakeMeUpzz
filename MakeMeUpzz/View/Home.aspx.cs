using MakeMeUpzz.Controller;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Session["userid"]);
            User currentUser = ViewUserController.GetUserHandler(userID);
            //mayhaps?
            lblWelcome.Text = $"Welcome, {currentUser.UserRole} {currentUser.Username}";

            if(currentUser.UserRole == "Customer")
            {
                pnlCustomerNav.Visible = true;
            }
            else if (currentUser.UserRole == "Admin")
            {
                pnlAdminNav.Visible = true;
                gvCustomers.Visible = true;
                bindUser();
            }

        }

        private void bindUser()
        {
            List<User> user = ViewUserController.GetAllUser();
            gvCustomers.DataSource = user;  
            gvCustomers.DataBind();
        }
         

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnManageMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMakeup.aspx");
        }

        protected void btnOrderQueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("HandleTransaction.aspx");
        }

        protected void btnProfileAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewTransactionReport.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Cookies["userid"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Home.aspx");

        }

        protected void btnOrderMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderMakeup.aspx");
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}