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
    public partial class ManageMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadMakeup();
            loadMakeupBrand();
            loadMakeupType();
        }
        protected void loadMakeup()
        {
            List<Makeup> makeup = ViewMakeupController.GetAllMakeup();
            gvMakeup.DataSource = makeup;
            gvMakeup.DataBind();
        }
        protected void loadMakeupType()
        {
            List<MakeupType> type = ViewMakeupTypeController.getAllMakeupTypes();
            gvMakeup.DataSource = type;
            gvMakeup.DataBind();
        }
        protected void loadMakeupBrand()
        {
            List<MakeupBrand> brand = ViewMakeupBrandController.getAllMakeupBrand();
            gvMakeup.DataSource = brand;
            gvMakeup.DataBind();
        }

        protected void btnDeleteMakeup_Click(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            int makeupId = Convert.ToInt32(btnDelete.CommandArgument);
            ViewMakeupController.removeMakeup(makeupId);
            loadMakeup();
        }
        protected void btnDeleteMakeupType_Click(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            string makeupTypeName = btnDelete.CommandArgument;
            ViewMakeupTypeController.removeType(makeupTypeName);
            loadMakeupType();
        }
        protected void btnDeleteMakeupBrand_Click(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            string makeupTypeBrand = btnDelete.CommandArgument;
            ViewMakeupBrandController.removeBrand(makeupTypeBrand);
            loadMakeupBrand();
        }
        protected void gvMakeup_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int makeupId = (int)gvMakeup.DataKeys[e.NewEditIndex].Value;
            Response.Redirect($"UpdateMakeup.aspx?ID={makeupId}");
        }
        protected void gvMakeupType_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int makeupTypeid = (int)gvMakeupType.DataKeys[e.NewEditIndex].Value;
            Response.Redirect($"UpdateMakeup.aspx?ID={makeupTypeid}");
        }
        protected void gvMakeupBrand_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int makeupBrandid = (int)gvMakeupBrand.DataKeys[e.NewEditIndex].Value;
            Response.Redirect($"UpdateMakeup.aspx?ID={makeupBrandid}");
        }

        protected void btnInsertMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMakeup.aspx");
        }

        protected void btnInsertMakeupType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMakeupType.aspx");
        }

        protected void btnInsertMakeupBrand_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMakeupBrand.aspx");
        }
    }
}