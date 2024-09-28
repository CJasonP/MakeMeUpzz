using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class InsertCartController
    {
        public static bool InsertCart(int userId, int productId, int quantity)
        {
            if (quantity <= 0)
            {
                return false;
            }
            InsertCartHandler.InsertCart(userId, productId, quantity);
            return true;
        }

        public static bool GetProduct(int id)
        {
            InsertCartHandler.getProduct(id);
            return true;
        }
    }
}