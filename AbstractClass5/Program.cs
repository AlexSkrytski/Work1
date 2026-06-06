namespace AbstractClass5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new("Коля", 100);

            manager.CalculateSalary(25);

            Worker worker = new("Дима", 100);

            worker.CalculateSalary(25);
        }
    }
}
