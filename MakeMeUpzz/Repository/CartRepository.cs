using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class CartRepository
    {
        static MakeMeUpzzDBEntities db = new MakeMeUpzzDBEntities();
        public static void insertCart(int userId, int makeupId, int quantity)
        {
            Cart newCart = CartFactory.insertCart(userId, makeupId, quantity); 
            db.Carts.Add(newCart);
            db.SaveChanges();
        }
        public static List<Cart> getAllCarts()
        {
            return db.Carts.ToList<Cart>();
        }
        public static List<Cart> getCart(int cartID)
        {
            return db.Carts.Where(a => a.CartID == cartID).ToList();
        }
        public static void removeCart(int cartID)
        {
            Cart cart = db.Carts.Where(a => a.CartID == cartID).FirstOrDefault();
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
        public static void removeAll()
        {
            db.Carts.RemoveRange(getAllCarts());
            db.SaveChanges();
        }
        public static void removeFromCart(int makeupId)
        {
            Cart cart = (from a in db.Carts where a.MakeupID == makeupId select a).FirstOrDefault();
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
    }
}