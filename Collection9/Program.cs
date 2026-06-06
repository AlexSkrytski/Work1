namespace Collection9
{

    //Заполнить список List<int> числами от 1 до 20. 
    //Пройтись по списку и удалить из него все четные числа.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variant1:

            List<int> list = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            list.RemoveAll(x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", list));

            //Variant2:

            List<int> numbers = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                numbers.Add(i);
            }

            // 2. Проходимся по списку в обратном порядке
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                // Проверяем, является ли число четным
                if (numbers[i] % 2 == 0)
                {
                    numbers.RemoveAt(i); // Удаляем четное число
                }
            }

            // Выводим оставшиеся числа, чтобы убедиться в результате
            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}