namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            
            myCar.MaxSpeed = -1000;

            myCar.PrintSpeed();
        }
    }
}
