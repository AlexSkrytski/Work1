using System.Runtime.InteropServices;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Balance = 5000;

            account.PrintBalance();

            account.Deposit(1000);
                      
            account.PrintBalance();

            account.Withdraw(7000);

            account.PrintBalance();

            Console.WriteLine("Hello, World!");
        }
    }
}
