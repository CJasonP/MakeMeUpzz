using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail newDetail(int transactionId, int makeupId, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionID = transactionId;
            transactionDetail.MakeupID = makeupId;
            transactionDetail.Quantity = quantity;
            return transactionDetail;
        }
    }
}