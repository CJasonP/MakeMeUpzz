using MakeMeUpzz.Controller;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace MakeMeUpzz.View
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadTransaction();
        }
        private void loadTransaction()
        {
            List<MakeMeUpzz.Models.TransactionDetail> transactions = TransactionDetailController.getAllDetail();
            gvTransactionDetail.DataSource = transactions;
            gvTransactionDetail.DataBind();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }
    }
}