using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP_Bank
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }


        public Transaction(int transactionId, decimal amount, DateTime transactionDate, string transactionType)
        {
            TransactionId = transactionId;
            Amount = amount;
            TransactionDate = transactionDate;
            TransactionType = transactionType;
        }
    }
    
   

}
