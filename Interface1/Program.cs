namespace Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = { new Airplane(), new Duck() };

            foreach (var item in flyables)
            {
                item.Fly(); 
            }
        }
    }
}
