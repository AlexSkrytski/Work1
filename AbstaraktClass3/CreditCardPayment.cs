using System;
using System.Collections.Generic;
using System.Text;

namespace AbstaractClass3
{
    public class CreditCardPayment : PaymentSystem
    {
        public decimal CreditLimit { get; set; }
        public CreditCardPayment(decimal initialBalance, decimal creditLimit)
    : base(initialBalance)
        {
            CreditLimit = creditLimit;
        }

        public override bool Pay(decimal amount)
        {
            if (amount <= 0) return false;

            // Если баланс + лимит позволяют провести оплату
            if (Balance - amount >= -CreditLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Оплата {amount:C} прошла успешно. Остаток: {Balance:C}");
                return true;
            }

            Console.WriteLine($"Ошибка оплаты {amount:C}. Превышен кредитный лимит.");
            return false;
        }
    }
}
