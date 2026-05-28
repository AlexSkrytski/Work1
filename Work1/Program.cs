namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BancAccaunt accaunt1 = new BancAccaunt();
            accaunt1.Deposit();
            Console.WriteLine(accaunt1.balance);
            accaunt1.Withdraw();
            Console.WriteLine(accaunt1.balance);
            
        }
    }
}
