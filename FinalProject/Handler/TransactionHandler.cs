using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Handler
{
    public class TransactionHandler
    {

        public static List<TransactionHeader> GetTransactions(int userId)
        {
            List<TransactionHeader> history = TransactionRepository.GetTransactions(userId);

            return history;
        }

        public static TransactionHeader CreateTransaction(int userId, List<Cart> cart, DateTime transactionDate)
        {
            TransactionHeader history = TransactionRepository.CreateTransaction(userId, cart, transactionDate);

            return history;
        }

        public static List<TransactionHeader> GetListTransactionHeaders()
        {
            List<TransactionHeader> history = TransactionRepository.GetListTransactionHeaders();
            if (history != null)
            {
                return history;
            }

            return null;
        }
    }
}