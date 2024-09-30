using FinalProject.Model;
using FinalProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using Cart = FinalProject.Model.Cart;
using TransactionDetail = FinalProject.Model.TransactionDetail;

namespace FinalProject.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateTransaction(int userId, List<Cart> cart, DateTime transactionDate)
        {

            var transaction = new TransactionHeader
            {
                UserID = userId,
                TransactionDate = transactionDate,
                TransactionDetails = cart.Select(stat => new TransactionDetail
                {
                    StationeryID = stat.StationeryID,
                    Quantity = stat.Quantity
                }).ToList()
            };

            return transaction;
        }


    }
}