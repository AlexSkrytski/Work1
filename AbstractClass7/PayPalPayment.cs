using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass7
{
    
        internal class PayPalPayment : PaymentMethod
        {
            public override void ProcessPayment()
            {
                if (Authorize())
                {
                    Console.WriteLine("Платеж с PayPal завершен.");
                }
            }

            public override void Refund()
            {
                if (Authorize())
                {
                    Console.WriteLine("Платеж будет возвращен на PayPal.");
                }
            }
        }
    
}
