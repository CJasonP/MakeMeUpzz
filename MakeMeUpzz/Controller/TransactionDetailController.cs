using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionDetailController
    {
        public static List<TransactionDetail> getAllDetail()
        {
            return TransactionDetailRepository.getAllTransaction();
        }
    }
}