using System;
using System.Collections.Generic;
using System.Text;

namespace Work1
{
    class BancAccaunt
    {

        public string AccountNomber = string.Empty;
        
        public decimal balance;
        public decimal amount;
        public BancAccaunt()
        {

            Console.WriteLine("Введите номер аккаунта:");
            AccountNomber = Console.ReadLine()!;
            Console.WriteLine("Введите баланс:");
            balance = decimal.Parse(Console.ReadLine()!);

        }

        public void Deposit()
        {

            Console.WriteLine("Введите сумму пополнения:");
            balance += decimal.Parse(Console.ReadLine()!);

        }
        public void Withdraw()
        {

            Console.WriteLine("Введите сумму для снятия");
            amount = decimal.Parse(Console.ReadLine()!);

            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств:");
            }

        }
    }
}
