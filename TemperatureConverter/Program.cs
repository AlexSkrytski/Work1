namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal c = 20;
            decimal f = 68;

            TemperatureConverter.CelsiusToFahrenheit(c);
            Console.WriteLine($"{c} градусов Цельсия, это {TemperatureConverter.F} градусов Фаренгейт.");

            TemperatureConverter.FahrenheitToCelsius(f);
            Console.WriteLine($"{f} градусов Фаренгейт, это {TemperatureConverter.C} градусов Цельсия.");

        }
    }
}
