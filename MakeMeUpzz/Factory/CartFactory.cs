using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class CartFactory
    {
        public static Cart insertCart(int userId, int makeupId, int quantity)
        {
            Cart cart = new Cart();
            cart.UserID = userId;
            cart.MakeupID = makeupId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}