using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Bank
{
    internal class BankAccount
    {
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }

            set { _balance = value; }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposit {amount} success!");
            }
            else
            {
                Console.WriteLine($"Deposit wrong: {amount} < 0!");
            }

        }
        public void Withdraw(decimal withdraw)
        {
            Console.WriteLine($"Withdraw: {withdraw}.");
           
            if (withdraw <= _balance)
            {
                _balance -= withdraw;

                Console.WriteLine($"Withdraw {withdraw} success!");

            }
            else
            {
                Console.WriteLine("Not enough money!");
            }

        }

        public void PrintBalance()
        {
            Console.WriteLine($"Ballance {_balance}.");
        }

    }
}
