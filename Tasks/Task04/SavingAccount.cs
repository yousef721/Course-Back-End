using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class SavingAccount : Account
    {
        public double IntRate { get; set; }
        public SavingAccount(string nameAccount = "Unknown", double balance = 0, double intRate = 0)
            : base (nameAccount,balance)
        {
            double IntRate = intRate;
        }

        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount + IntRate);
        }
    }
    
}
