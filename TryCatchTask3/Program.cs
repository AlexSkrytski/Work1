namespace TryCatchTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 20, 30, 40, 50 };

            try
            {
                Console.WriteLine("Введите индекс элемента массива:");
                int index = int.Parse(Console.ReadLine());

                Console.WriteLine(ints[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Неверный индекс!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите цифры!");
            }
            finally
            {
                Console.WriteLine("sadsa");
            }
            
        }
    }
}
