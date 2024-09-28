using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userrole"].ToString() == "Administrator")
            {
                loadTransaction();
            }
            else
            {
                int customerId = Convert.ToInt32(Session["userid"]);
                loadCustomerTransaction(customerId);
            }

        }
        protected void btnViewDetails_Click(object sender, EventArgs e)
        {
            Button btnViewDetails = (Button)sender;
            int transactionId = Convert.ToInt32(btnViewDetails.CommandArgument);
            Response.Redirect($"TransactionDetails.aspx?TransactionID={transactionId}");
        }
        
        protected void loadTransaction()
        {
            var transactions = TransactionHistoryController.getAllHistory();
            gvTransactionHistory.DataSource = transactions;
            gvTransactionHistory.DataBind();
        }

        protected void loadCustomerTransaction(int id)
        {
            var transactions = TransactionHistoryController.getAllCustomer(id);
            gvTransactionHistory.DataSource = transactions;
            gvTransactionHistory.DataBind();
        }
    }
}