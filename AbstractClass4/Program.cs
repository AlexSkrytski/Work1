namespace AbstractClass4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CreditCard test = new ("1111 2222 3333 4444", 100);
            test.Pay(50);

            DebitCard test1 = new ("1112 2223 3334 4445", 200);
            test1.Pay(250);

        }
    }
}
