using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class CheckingAccount : Account
    {
        public double Fee { get; set; }
        public CheckingAccount(string nameAccount = "Unknown", double balance = 0, double fee = 1.5)
            : base(nameAccount, balance) 
        {
           double Fee = fee;
        }

        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }
    }

}

