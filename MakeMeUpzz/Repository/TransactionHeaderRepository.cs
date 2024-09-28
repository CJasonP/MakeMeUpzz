using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace MakeMeUpzz.Repository
{
    public class TransactionHeaderRepository
    {
        static MakeMeUpzzDBEntities db = new MakeMeUpzzDBEntities();
        public static int newHeader(int userId, DateTime date, string status)
        {
            TransactionHeader header = TransactionHeaderFactory.newTransaction(userId, date, status);
            db.TransactionHeaders.Add(header);
            db.SaveChanges();
            return header.TransactionID;
        }
        public static TransactionHeader getTransaction(int transactionID)
        {
            TransactionHeader header = (from a  in db.TransactionHeaders where a.TransactionID == transactionID select a).FirstOrDefault();
            return header;
        }

        public static List<TransactionHeader> getTransactionHeaders()
        {
            return db.TransactionHeaders.ToList();
        }
        public static void HandleTransactionStatus(int transactionId)
        {
            TransactionHeader transaction = getTransaction(transactionId);
            if (transaction != null)
            {
                transaction.Status = "Handled";
                db.SaveChanges();
            }
        }

        public static List<TransactionHeader> getCustomerTransaction(int userId)
        {
            List<TransactionHeader> transactions = (from a in db.TransactionHeaders
                                                    where a.UserID == userId
                                                    select a).ToList();
            return transactions;
        }
    }
}