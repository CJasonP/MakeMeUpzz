using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class ViewCartController
    {
        public static List<Cart> GetAllCart()
        {
            return ViewCartHandler.getAllCart();
        }

        public static void RemoveCart(int cartID)
        {
            ViewCartHandler.removeCart(cartID);
        }

        public static void ClearCart()
        {
            ViewCartHandler.removeAll();
        }

        public static void Checkout(int userId)
        {
            var carts = ViewCartHandler.getAllCart();
            foreach (var cart in carts)
            {
                ViewCartHandler.addTransaction(userId, DateTime.Now, "Unhandled");
                ViewCartHandler.removeCart(cart.CartID);
            }
        }
    }
}