using FinalProject.Factory;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Repository
{
    public class TransactionRepository
    {
        static DatabaseEntities1 db = new DatabaseEntities1();

        public string GetNameById(int userId)
        {
            var user = db.MsUsers.FirstOrDefault(x => x.UserID == userId);

            return user.UserName;
        }

        public static TransactionHeader CreateTransaction(int userId, List<Cart> cart, DateTime transactionDate)
        {
            using (DatabaseEntities1 db = new DatabaseEntities1())
            {
                TransactionHeader history = TransactionFactory.CreateTransaction(userId, cart, transactionDate);

                db.TransactionHeaders.Add(history);
                db.SaveChanges();

                return history;
            }
        }

        public static List<TransactionHeader> GetTransactions(int userId)
        {
            List<TransactionHeader> history = db.TransactionHeaders.Where(x => x.UserID == userId).ToList();

            return history;
        }

        public static List<TransactionHeader> GetListTransactionHeaders()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}