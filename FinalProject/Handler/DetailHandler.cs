using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Handler
{
    public class DetailHandler
    {

        public static List<TransactionDetail> GetDetails(int transactionId)
        {
            List<TransactionDetail> detail = DetailRepository.GetDetails(transactionId);

            return detail;
        }
    }
}