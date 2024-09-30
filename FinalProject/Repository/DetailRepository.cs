using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Repository
{
    public class DetailRepository
    {
        static DatabaseEntities1 db = new DatabaseEntities1();
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

        public static List<TransactionDetail> GetDetails(int transactionId)
        {
            List<TransactionDetail> detail = db.TransactionDetails.Where(x => x.TransactionID == transactionId).ToList();

            return detail;
        }
    }
}