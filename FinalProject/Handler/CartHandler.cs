using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Handler
{
    public class CartHandler
    {

        public static List<Cart> GetCarts()
        {
            DatabaseEntities1 db = new DatabaseEntities1();

            List<Cart> cart = db.Carts.ToList();

            return cart;
        }

        public static bool DeleteCart(int userId, int stationeryId)
        {
            return CartRepository.DeleteCart(userId, stationeryId);
        }

        public static Cart CreateCart(int userId, int stationeryId, int quantity)
        {
            Cart cart = CartRepository.CreateCart(userId, stationeryId, quantity);
            return cart;
        }

        public static void DeleteProduct(int id)
        {
            CartRepository.DeleteProduct(id);
        }

        public static void UpdateCart(int userId, int stationeryId, int quantity)
        {
            CartRepository.UpdateCart(userId, stationeryId, quantity);
        }
    }
}