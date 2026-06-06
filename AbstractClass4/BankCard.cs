using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass4
{
    public abstract class BankCard
    {

        protected BankCard(string cardNumber, decimal initialBalance)
        {
            Balance = initialBalance;

            CardNumber = cardNumber;
        }
        public string CardNumber { get; set; }
        public decimal Balance { get; protected set; }
        public abstract void Pay(decimal amount);

    }
}
