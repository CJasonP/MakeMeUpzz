using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class InsertMakeupType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                if (InsertMakeupController.getUserObj(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
                lblError.Visible = false;
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblError.Visible = true;
            string name = tbName.Text;

            lblError.Text = InsertMakeupTypeController.InsertMakeupType(name);
        }
    }
}