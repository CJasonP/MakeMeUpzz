using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class UpdateMakeupBrand : System.Web.UI.Page
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
            int rating = Int32.Parse(tbRating.Text);
            UpdateMakeupBrandController.UpdateMakeupBrand(id, name, rating);

            Response.Redirect("ManageMakeup.aspx");
        }
    }
}