using FinalProject.Handler;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Controller
{
    public class DetailController
    {

        public static List<TransactionDetail> GetDetails(int transactionId)
        {
            List<TransactionDetail> detail = DetailHandler.GetDetails(transactionId);

            return detail;
        }
    }
}