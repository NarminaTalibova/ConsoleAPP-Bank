using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP_Bank
{
    public interface IAccount
    {
        int AccountId { get; }
        decimal Balance { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

}
