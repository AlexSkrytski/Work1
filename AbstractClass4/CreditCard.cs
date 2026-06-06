using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass4
{
    internal class CreditCard : BankCard
    {
        public CreditCard(string cardNumber, decimal initialBalance) : base(cardNumber, initialBalance)
        {
        }

        public override void Pay(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"С карты № {CardNumber} cписано {amount}, остаток {Balance}.");
        }

    }
}
