using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class ViewCartHandler
    {
        public static void removeCart(int cartID)
        {
            CartRepository.removeCart(cartID);
        }
        public static List<Cart> getAllCart()
        {
            return CartRepository.getAllCarts();
        }
        public static void removeAll()
        {
            CartRepository.removeAll();
        }
        public static void addTransaction(int id, DateTime date, string status)
        {
            TransactionHeaderRepository.newHeader(id, date, status);
        }
    }
}