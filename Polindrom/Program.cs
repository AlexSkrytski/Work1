namespace Polindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Введите слово: " );
            string original = Console.ReadLine()!;
            original = original.ToLower();
            string reversed = new string(original.Reverse().ToArray());
            //reversed = reversed.ToString();
            reversed = reversed.ToLower();

            if (original == reversed)
            {
                Console.WriteLine("Полиндром!");
            }
            else
            {
                Console.WriteLine("Не полиндром!");
            }

        }
    }
}
