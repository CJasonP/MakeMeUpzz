using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class InsertCartHandler
    {
        public static void InsertCart(int userId, int productId, int quantity)
        {
            CartRepository.insertCart(userId, productId, quantity);
        }
        public static List<Cart> checkCart(int productID)
        {
            return CartRepository.getCart(productID);
        }
        public static void deleteItemFromCart(int id)
        {
            CartRepository.removeFromCart(id);
        }
        public static void getProduct(int id)
        {
            CartRepository.getCart(id);
        }


    }
}