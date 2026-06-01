namespace TryCathTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите делимое: ");
                double dividend = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите делитель: ");
                double divisor = Convert.ToDouble(Console.ReadLine());

                // Так как тип double, деление на ноль вернет Infinity, 
                // поэтому для генерации DivideByZeroException используем int
                int intDividend = Convert.ToInt32(dividend);
                int intDivisor = Convert.ToInt32(divisor);

                int result = intDividend / intDivisor;
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, используйте только цифры.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Операция завершена.");
            }
        }
    }
}
