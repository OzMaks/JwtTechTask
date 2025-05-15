using JwtTechTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtTechTask.Utility
{
    public static class TransactionProcessor
    {
        public static void PrintUserTransactionSummary(UserTransactionData user)
        {
            double totalConfirmedAmount = 0;
            int confirmedCount = 0;

            foreach (var txn in user.Transactions)
            {
                if (txn.Meta?.Confirmed == true || txn.Status?.ToString() == "Completed")
                {
                    totalConfirmedAmount += txn.Amount;
                    confirmedCount++;
                }
            }

            Console.WriteLine($"User: {user.UserId}, " +
                $"Transactions: {user.Transactions.Count}, " +
                $"Total Confirmed Amount: {totalConfirmedAmount}");

        }
    }
}
