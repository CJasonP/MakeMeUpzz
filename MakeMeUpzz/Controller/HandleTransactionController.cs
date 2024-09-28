using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class HandleTransactionController
    {
        public static List<TransactionHeader> GetAllTransactionHeaders()
        {
            return HandleTransactionHandler.GetAllTransactionHeaders();
        }

        public static void HandleTransaction(int transactionId)
        {
            HandleTransactionHandler.HandleTransaction(transactionId);
        }
    }
}