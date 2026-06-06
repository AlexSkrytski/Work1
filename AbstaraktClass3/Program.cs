using AbstaractClass3;

namespace AbstaraktClass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment[] test = { new CreditCardPayment(30, 20), new CreditCardPayment(100, 10), new CreditCardPayment(110, 20) };

            test[0].Pay(20);
            test[0].Deposit(20);
            test[1].Pay(30);
            test[2].Pay(40);

        }
    }
}
