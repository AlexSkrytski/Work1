namespace Throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Блок Try");
                throw new Exception("Ошибка!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Блок Catch: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок Finally");
            }
            Console.WriteLine("Конец программы");
        }
    }
}
