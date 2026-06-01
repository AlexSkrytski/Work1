namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rec = new Rectangle(5, 20);
            Console.WriteLine($"Площадь = {rec.GetArea}");
            Console.WriteLine($"Периметр = {rec.GetPerimeter()}");

        }
    }
}
