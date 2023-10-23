using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP_Bank
{
    public class Bank
    {
        private List<Account> accounts = new List<Account>();

        public void CreateAccount(int accountId, decimal balance)
        {
            accounts.Add(new Account(accountId, balance));
        }

        public List<Account> GetAllAccounts()
        {
            return accounts;
        }

        public void DepositMoney(int accountId, decimal amount)
        {
            try
            {
               
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void WithdrawMoney(int accountId, decimal amount)
        {
            try
            {
                
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TransferMoney(int fromAccountId, int toAccountId, decimal amount)
        {
            try
            {
               
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
