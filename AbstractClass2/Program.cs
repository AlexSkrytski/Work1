using System.Drawing;

namespace AbstractClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employs = { new Manager("Alex", 5, 7), new Developer("NIck", 6, 1.3m) };

            foreach (var employ in employs) employ.PrintInfo();
        }
    }
}
