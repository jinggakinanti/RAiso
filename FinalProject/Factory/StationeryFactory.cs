using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Factory
{
    public class StationeryFactory
    {
        public static MsStationery CreateStationery(String name, int price)
        {
            MsStationery stationery = new MsStationery();
            stationery.StationeryName = name;
            stationery.StationeryPrice = price;
            
            return stationery;
        }
    }
}