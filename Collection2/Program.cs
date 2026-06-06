namespace Collection2
{
    //Задача: Дан список целых чисел(List<int>) с возможными повторениями.
    //Создайте метод, который удаляет все дубликаты и возвращает новый 
    //список, отсортированный по возрастанию.
    internal class Program
    {
        public static List<int> RemoveDuplicatesAndSort(List<int> inputList)
        {
            if (inputList == null)
                return new List<int>();

            return inputList
                .Distinct()
                .OrderBy(x => x)
                .ToList(); //Distinct - removes duplicates from input. OrderBY Sorts the remaining unique items in ascending order. ToLIst converts the result back into a List<>.
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 9, 5, 2, 3, 1, 9 };

            List<int> result = RemoveDuplicatesAndSort(numbers);

            Console.WriteLine(string.Join(", ", result)); //string.Join(", ", result): This method combines individual elements from the result collection into a single string with separator "," between items.
        }
    }
}
