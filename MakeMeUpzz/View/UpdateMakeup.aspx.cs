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
    public partial class UpdateMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] == null)
            {
                Response.Redirect("ManageMakeup.aspx");
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            string name = tbName.Text;
            int price = Int32.Parse(tbPrice.Text);
            int weight = Int32.Parse(tbWeight.Text);
            int typeId = Int32.Parse(tbType.Text);
            int brandId = Int32.Parse(tbBrand.Text);

            UpdateMakeupController.UpdateMakeup(id, name, price, weight, typeId, brandId);

            Response.Redirect("ManageMakeup.aspx");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMakeup.aspx");
        }
    }
}