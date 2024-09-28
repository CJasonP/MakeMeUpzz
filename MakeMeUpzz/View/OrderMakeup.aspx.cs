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
    public partial class OrderMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindMakeupData();
        }
        protected void btnClearCart_Click(object sender, EventArgs e)
        {
            ViewCartController.ClearCart();
            lblMessage.Text = "Cart Cleared";
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["ID"]);
            ViewCartController.Checkout(id);
            lblMessage.Text = "Cart has been Checkout";
        }
        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            int makeupId = Convert.ToInt32(btnOrder.CommandArgument);
            TextBox tbQuantity = (TextBox)row.FindControl("tbQuantity");

            int quantity;
            if (Int32.TryParse(tbQuantity.Text, out quantity))
            {
                int userId = Int32.Parse(Session["userid"].ToString()); 
                InsertCartController.InsertCart(userId, makeupId, quantity);

                lblMessage.Text = "Item added to cart";
            }
            else
            {
                lblMessage.Text = "Invalid quantity";
            }
        }
        private void BindMakeupData()
        {
            List<Makeup> makeupList = ViewMakeupController.GetAllMakeup();
            gvMakeup.DataSource = makeupList;
            gvMakeup.DataBind();
        }
    }
}