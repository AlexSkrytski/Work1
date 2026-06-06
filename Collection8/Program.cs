using System.Collections;
using System.Linq.Expressions;

namespace Collection8
{

    //Реализовать консольный редактор текста(или чисел). 
    //Программа должна принимать числа(новые состояния) 
    //и сохранять их.Пользователь может ввести команду "undo",
    //чтобы отменить последнее изменение и вернуться к предыдущему 
    //состоянию.
    //Идеальная коллекция: Stack<T> — работает по принципу 
    //LIFO(последний вошел — первый вышел).
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "undo")

                    try
                    {
                        stack.Pop();
                    }
                    catch (System.InvalidOperationException)
                    {
                        Console.WriteLine("Нечего отменять.");
                    }

                else stack.Push(input);

                Console.WriteLine();

                foreach (var item in stack)
                {
                    Console.Write($"{item} ");
                }
            }

        }
    }
}
