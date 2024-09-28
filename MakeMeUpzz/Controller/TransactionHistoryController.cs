using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionHistoryController
    {
        public static List<TransactionHeader> getAllHistory()
        {
            return TransactionHistoryHandler.getAllHistory();
        }
        public static List<TransactionHeader> getAllCustomer(int userId)
        {
            return TransactionHistoryHandler.getAllCustomer(userId);
        }
    }
}