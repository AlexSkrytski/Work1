using AbstractClass1;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 6) };

            foreach (var shape in shapes) shape.PrintInfo();
        }
    }
}
