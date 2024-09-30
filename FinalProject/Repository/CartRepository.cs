using FinalProject.Factory;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Repository
{
    public class CartRepository
    {
        static DatabaseEntities1 db = new DatabaseEntities1();
        public static Cart CreateCart(int userId, int stationeryId, int quantity)
        {
            Cart cart = CartFactory.CreateCart(userId, stationeryId, quantity);

            db.Carts.Add(cart);
            db.SaveChanges();

            return cart;
        }

        public string GetNameById(int stationeryId)
        {
            var stat = db.MsStationeries.FirstOrDefault(x => x.StationeryID == stationeryId);

            return stat.StationeryName;
        }

        public int GetPriceById(int stationeryId)
        {
            var stat = db.MsStationeries.FirstOrDefault(x => x.StationeryID == stationeryId);

            return stat.StationeryPrice;
        }

        public static void DeleteProduct(int id)
        {
            db.Carts.Remove((from x in db.Carts where x.StationeryID == id select x).ToList().FirstOrDefault());
            db.SaveChanges();
        }

        public static Cart GetById(int id)
        {
            Cart cart = (from x in db.Carts where x.StationeryID == id select x).ToList().FirstOrDefault();
            return cart;
        }

        public static void UpdateCart(int userId, int stationeryId, int quantity)
        {
            Cart cart = db.Carts.Find(userId, stationeryId);

            cart.Quantity = quantity;

            db.SaveChanges();
        }

        public static bool DeleteCart(int userId, int stationeryId)
        {
            using (var db = new DatabaseEntities1())
            {
                var cart = db.Carts.Find(userId, stationeryId);
                
                db.Carts.Remove(cart);
                
                return db.SaveChanges() > 0;
            }
        }

    }
}
