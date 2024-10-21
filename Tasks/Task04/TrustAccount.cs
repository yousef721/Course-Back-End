using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class TrustAccount : SavingAccount
    {
        public int Count {  get; set; }  
        public int CreateAccountDate { get; set; }
        public TrustAccount(string nameAccount = "Unknown", double balance = 0, double intRate = 0) : base(nameAccount, balance, intRate) 
        {
            Count = 0;
            CreateAccountDate = DateTime.Now.Year;
        }


        public new bool Deposit(double amount)
        {
            if (amount >= 5000)
            {
                
                return base.Deposit(amount + 50);
            } else
            {
                return base.Deposit(amount);
            }
        }
        public void CountWithdrawInYear()
        {
            int timeNow = DateTime.Now.Year;

            if (timeNow != CreateAccountDate)
            {
                Count = 0;
            }
            else
            {
                Count++;
            }
        }
        public bool Withdraw(double amount)
        {

            if (Balance * 0.2 >= amount && Count <= 3)
            {
                CountWithdrawInYear();
                return base.Withdraw(amount);

            }else
            {
                return false;
            }
        }
        
    }
}
