using FinalProject.Handler;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Controller
{
    public class StationeryController
    {
        public static List<MsStationery> GetStationeries()
        {
            List<MsStationery> stat = StationeryHandler.GetStationeries();

            return stat;
        }

        public static String CreateStationery(String name, int price)
        {
            MsStationery stat = StationeryHandler.CreateStationery(name, price);
            return "Insert Successful";
        }

        public static void DeleteProduct(string name)
        {
            StationeryHandler.DeleteProduct(name);
        }

        public static void UpdateStationery(int id, String name, int price)
        {
            StationeryHandler.UpdateStationery(id, name, price);
        }
    }
}