using System;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Sean Morgan", 1000.00m);

            Console.WriteLine($"Account Owner: {account.Owner}\tAccount# {account.Number}");

            account.MakeDeposit(4530.25m, DateTime.Now, "Paycheck");

            account.MakeWithdrawal(1275.00m, DateTime.Now, "Pay mortgage");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
