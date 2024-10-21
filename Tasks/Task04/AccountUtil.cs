using System;
using System.Collections.Generic;
using System.Security.Principal;
using Task04;

public static class AccountUtil
{
    // Utility helper functions for Account class

    public static void Display(List<Account> accounts)
    {
        Console.WriteLine("\n=== Accounts ==========================================");
        foreach (var acc in accounts)
        {
            Console.WriteLine(acc.Display());
        }
    }

    public static void Deposit(List<Account> accounts, double amount)
    {
        Console.WriteLine("\n=== Depositing to Accounts =================================");
        foreach (var acc in accounts)
        {
            if (acc.Deposit(amount))
                Console.WriteLine($"Deposited {amount} to {acc.NameAccount}");
            else
                Console.WriteLine($"Failed Deposit of {amount} to {acc.NameAccount}");
        }
    }

    public static void Withdraw(List<Account> accounts, double amount)
    {
        Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
        foreach (var acc in accounts)
        {
            if (acc.Withdraw(amount))
                Console.WriteLine($"Withdrew {amount} from {acc.NameAccount}");
            else
                Console.WriteLine($"Failed Withdrawal of {amount} from {acc.NameAccount}");
        }
    }

    // Helper functions for Savings Account class

    // Helper functions for Checking Account class

    // Helper functions for Trust account class
}