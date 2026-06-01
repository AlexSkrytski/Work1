using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace TryCatchTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите делимое:");
                int value1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите делитель:");
                int value2 = int.Parse(Console.ReadLine());

                int res = value1 / value2;

                Console.WriteLine($"Результат: {res}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, используйте только цифры.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            }
            finally
            {
                Console.WriteLine("Операция завершена.");
            }

        }
    }

}






