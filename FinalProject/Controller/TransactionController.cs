using FinalProject.Handler;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Controller
{
    public class TransactionController
    {
        public static List<TransactionHeader> GetTransactions(int userId)
        {
            List<TransactionHeader> history = TransactionHandler.GetTransactions(userId);

            return history;
        }

        public static TransactionHeader CreateTransaction(int userId, List<Cart> cart, DateTime transactionDate)
        {
            TransactionHeader history = TransactionHandler.CreateTransaction(userId, cart, transactionDate);

            return history;
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            List<TransactionHeader> history = TransactionHandler.GetListTransactionHeaders();
            return history;
        }
    }
}