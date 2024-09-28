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
    public partial class HandleTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadTransaction();
        }
        private void loadTransaction()
        {
            List<TransactionHeader> transactions = HandleTransactionController.GetAllTransactionHeaders();
            gvTransactions.DataSource = transactions;
            gvTransactions.DataBind();
        }
        protected void btnHandle_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int transactionId = int.Parse(btn.CommandArgument);
            HandleTransactionController.HandleTransaction(transactionId);
            loadTransaction();
        }
        protected void gvTransactions_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Button btnHandle = (Button)e.Row.FindControl("btnHandle");
                string status = DataBinder.Eval(e.Row.DataItem, "Status").ToString();
                btnHandle.Visible = (status == "Unhandled");
            }
        }
    }
}