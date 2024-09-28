using MakeMeUpzz.Controller;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class InsertMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["user"] == null)
            //{
            //    Response.Redirect("Home.aspx");
            //}
            //else
            //{
            //    if (InsertMakeupController.getUserObj(Session["user"]))
            //    {
            //        Response.Redirect("Home.aspx");
            //    }
            //    lblError.Visible = false;
            //}
        }


        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMakeup.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int price = Int32.Parse(tbPrice.Text.ToString());
            int weight = Int32.Parse(tbWeight.Text.ToString());
            int typeId = Int32.Parse(tbType.Text.ToString());
            int brandId = Int32.Parse(tbBrand.Text.ToString());
            lblError.Visible = true;
            lblError.Text = InsertMakeupController.InsertNewMakeup(name, price, weight, typeId, brandId);
        }
    }
}
