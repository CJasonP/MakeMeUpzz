using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class HandleTransactionHandler
    {
        public static List<TransactionHeader> GetAllTransactionHeaders()
        {
            return TransactionHeaderRepository.getTransactionHeaders();
        }
        public static void HandleTransaction(int transactionId)
        {
            TransactionHeaderRepository.HandleTransactionStatus(transactionId);
        }
    }
}