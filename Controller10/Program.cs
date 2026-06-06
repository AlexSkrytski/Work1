namespace Controller10
{

    //Задача 1 (Удаление по условию): Создайте список целых чисел от 1 до 50. 
    //Удалите из него все четные числа, а оставшиеся элементы возведите в квадрат.
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            List<int> listFiltred = new List<int>();

            for (int i = 1; i <= 50; i++)
            {
                list.Add(i);
            }

            list.RemoveAll(x => x%2 == 0);

            foreach (var item in list)
            {
                listFiltred.Add(item * item);
            }

            Console.WriteLine(string.Join(", ", listFiltred));

            //Variant 2: LinQ

            var numbers = Enumerable.Range(1, 50);

            // Фильтруем (оставляем нечетные) и возводим в квадрат
            var results = numbers
                .Where(x => x % 2 != 0)
                .Select(x => x * x)
                .ToList();

            // Выводим результат
            Console.WriteLine(string.Join(", ", results));

        }
    }
}
