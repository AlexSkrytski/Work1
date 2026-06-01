namespace Throw2
{
    internal class Program
    {
        public static void RegisterUser(string userName)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }

            else if (userName.Length == 0)
            {
                throw new ArgumentException(nameof(userName));
            }
            else Console.WriteLine("Ok!");
        }
        public static void SetDiscount(int percent)
        {
            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Скидка должна быть в диапазоне от 0 до 100 процентов.");
            }

            Console.WriteLine($"Скидка установлена: {percent}%");
        }
        static void Main(string[] args)
        {
            //SetDiscount(110);
            RegisterUser(null);
        }
    }
}
