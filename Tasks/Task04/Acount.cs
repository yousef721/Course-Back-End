using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Account
    {
        public string NameAccount { get; set; }
        public double Balance { get; set; }

        public Account(string nameAccount = "Unknown", double balance = 0)
        {
            NameAccount = nameAccount;
            Balance = balance;
        }

        public string Display()
        {
            return $"Name is: {NameAccount}. Your balance is: {Balance}";
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            } else
            {
                return false;
            }
        }

        public bool Withdraw(double amount)
        {
            double newBalance = Balance - amount;
            if (newBalance > 0)
            {
                Balance = newBalance;
                return true;
            }
            else
            {
                return false;   
            }
        }

        public static Account operator +(Account account1, Account account2) 
        {
            Account account = new Account();
            account.Balance = account1.Balance + account2.Balance;
            return account;
        } 
    }
}
