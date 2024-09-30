using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Handler
{
    public class StationeryHandler
    {
        public static List<MsStationery> GetStationeries()
        {

            DatabaseEntities1 db = new DatabaseEntities1();

            List<MsStationery> stat = db.MsStationeries.ToList();

            return stat;
        }

        public static MsStationery CreateStationery(String name, int price)
        {
            MsStationery stat = StationeryRepository.CreateStationery(name, price);
            return stat;
        }

        public static void DeleteProduct(string name)
        {
            StationeryRepository.DeleteProduct(name);
        }

        public static void UpdateStationery(int id, String name, int price)
        {
            StationeryRepository.UpdateStationery(id, name, price);
        }
    }
}