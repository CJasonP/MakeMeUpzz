using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using MakeMeUpzz.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class TransactionHistoryHandler
    {
        public static List<TransactionHeader> getAllHistory()
        {
            return TransactionHeaderRepository.getTransactionHeaders();
        }

        public static List<TransactionHeader> getAllCustomer(int userId)
        {
            return TransactionHeaderRepository.getCustomerTransaction(userId);
        }
    }
}