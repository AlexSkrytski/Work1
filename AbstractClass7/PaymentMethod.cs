using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass7
{
    public abstract class PaymentMethod
    {
        public bool IsVeryfied;
        public bool Authorize()
        {
            return IsVeryfied = true;
        }
        public abstract void ProcessPayment();
        public abstract void Refund();


    }
}
