using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class TransactionDetailHandler
    {
        public static List<TransactionDetail> getAllDetail()
        {
            return TransactionDetailRepository.getAllTransaction();
        }
    }
}