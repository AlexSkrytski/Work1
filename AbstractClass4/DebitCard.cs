using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass4
{
    internal class DebitCard : BankCard
    {
        public DebitCard(string cardNumber, decimal initialBalance) : base(cardNumber, initialBalance)
        {
        }

        public override void Pay(decimal amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine($"С карты № {CardNumber} cписано {amount}, остаток {Balance}.");
            }
            else
            {
                Console.WriteLine($"На карте № {CardNumber} недостаточно средств.");
            }
        }

    }
}
