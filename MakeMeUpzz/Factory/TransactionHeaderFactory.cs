using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader newTransaction(int userId, DateTime transactionDate, string status)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            //transactionHeader.TransactionID = transactionId;
            transactionHeader.UserID = userId;
            transactionHeader.TransactionDate = transactionDate;
            transactionHeader.Status = status;
            return transactionHeader;
        }
    }
}