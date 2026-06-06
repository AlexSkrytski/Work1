using System;
using System.Collections.Generic;
using System.Text;

namespace AbstaractClass3
{
    public abstract class PaymentSystem
    {
        public decimal Balance { get; protected set; }
        protected PaymentSystem(decimal initialBalance)
        {
            Balance = initialBalance;
        }
        public void Deposit(decimal deposit)
        {
            if (deposit > 0)
            {
                Balance += deposit;
                Console.WriteLine($"Пополнено на: {deposit:C}. Баланс: {Balance:C}");//:C (Спецификатор формата): означает Currency (валюта). Он автоматически форматирует число как денежную единицу в соответствии с текущими региональными настройками (культурой) вашей системы.
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine(Balance);
        }
        public abstract bool Pay(decimal amount);

    }
}
