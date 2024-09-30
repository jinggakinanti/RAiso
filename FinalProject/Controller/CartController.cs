using FinalProject.Handler;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Controller
{
    public class CartController
    {
        public static List<Cart> GetCarts()
        {
            List<Cart> cart = CartHandler.GetCarts();

            return cart;
        }

        public static bool DeleteCart(int userId, int stationeryId)
        {
            return CartHandler.DeleteCart(userId, stationeryId);
        }

        public static Cart CreateCart(int userId, int stationeryId, int quantity)
        {
            Cart cart = CartHandler.CreateCart(userId, stationeryId, quantity);
            return cart;
        }

        public static void DeleteProduct(int id)
        {
            CartHandler.DeleteProduct(id);
        }

        public static void UpdateCart(int userId, int stationeryId, int quantity)
        {
            CartHandler.UpdateCart(userId, stationeryId, quantity);
        }
    }
}