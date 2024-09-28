using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace MakeMeUpzz.Repository
{
    public class TransactionDetailRepository
    {
        static MakeMeUpzzDBEntities db = new MakeMeUpzzDBEntities();
        public static List<TransactionDetail> getAllTransaction()
        {
            return db.TransactionDetails.ToList();
        }
        public static List<TransactionDetail> getTransactionDetails(int transactionID)
        {
            List<TransactionDetail> detail = (from a in db.TransactionDetails where a.TransactionID == transactionID select a).ToList();
            return detail;
        }
        public static void newTransactionDetail(int transactionID, int productID, int quantity)
        {
            TransactionDetail detail = TransactionDetailFactory.newDetail(transactionID, productID, quantity);
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }
    }
}