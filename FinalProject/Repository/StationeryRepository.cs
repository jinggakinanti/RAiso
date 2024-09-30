using FinalProject.Factory;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Repository
{
    public class StationeryRepository
    {
        static DatabaseEntities1 db = new DatabaseEntities1();
        public static MsStationery CreateStationery(String name, int price)
        {
            MsStationery stationery = StationeryFactory.CreateStationery(name, price);

            db.MsStationeries.Add(stationery);
            db.SaveChanges();

            return stationery;
        }

        public static void DeleteProduct(int id)
        {
            db.TransactionDetails.Remove((from x in db.TransactionDetails where x.StationeryID == id select x).ToList().FirstOrDefault());
            db.MsStationeries.Remove((from x in db.MsStationeries where x.StationeryID == id select x).ToList().FirstOrDefault());
            db.SaveChanges();
        }

        public static MsStationery GetById(int id)
        {
            MsStationery stat = (from x in db.MsStationeries where x.StationeryID == id select x).ToList().FirstOrDefault();
            return stat;
        }

        public static void UpdateStationery(int id, String name, int price)
        {
            MsStationery stat = db.MsStationeries.Find(id);

            stat.StationeryName = name;
            stat.StationeryPrice = price;

            db.SaveChanges();
        }
    }
}