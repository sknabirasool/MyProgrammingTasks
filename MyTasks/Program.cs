
using System;
namespace MyTasks;
class Program
{
    static void Main(String[] args)
    {
        var account = new BankAccount("ICICI BANK", 100000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.balance}");
        account.MakeWithdrawal(150, DateTime.Now, "Restarent");
        Console.WriteLine(account.balance);

        Console.WriteLine(account.GetAccountHistory());
        // Test that the initial balances must be positive.
       
        try
        {
            var invalidAccount = new BankAccount("invalid", -55);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught creating account with negative balance");
            Console.WriteLine(e.ToString());
            return;
        }
        account.MakeDeposit(12000, DateTime.Now, "Transfer To Account Holder");
        Console.WriteLine(account.balance);

        
    }
}

