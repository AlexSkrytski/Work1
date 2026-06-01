namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            string input = Console.ReadLine();

            try
            {
                // Пытаемся преобразовать введенную строку в целое число
                int number = int.Parse(input);
                Console.WriteLine($"Вы успешно ввели число: {number}");
            }
            catch (FormatException)
            {
                // Ошибка срабатывает, если пользователь ввел буквы, символы или дроби
                Console.WriteLine("Ошибка: введено некорректное число. Попробуйте еще раз!");
            }
            catch (OverflowException)
            {
                // Ошибка срабатывает, если число слишком большое или слишком маленькое для типа int
                Console.WriteLine("Ошибка: введенное число слишком большое или слишком маленькое!");
            }
        }
    }
}
