using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP_Bank
{
    public class Account : IAccount
    {
        private List<Transaction> transactions = new List<Transaction>();

        public int AccountId { get; set; }
        public decimal Balance { get; set; }

        public Account(int accountId, decimal balance)
        {
            AccountId = accountId;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Depozit məbləği sıfırdan çox olmalıdır.");

            Balance += amount;
            transactions.Add(new Transaction(transactions.Count + 1, amount, DateTime.Now, "Deposit"));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Withdrawal (Çıxarılan) məbləğ sıfırdan çox olmalıdır.");

            if (amount > Balance)
                throw new InsufficientFundsException("Çıxarmaq üçün kifayət qədər vəsait yoxdur.");

            Balance -= amount;
            transactions.Add(new Transaction(transactions.Count + 1, amount, DateTime.Now, "Withdraw"));
        }

    }
}

    

