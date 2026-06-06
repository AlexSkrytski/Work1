namespace Collection6
{

    //Дан текстовый массив с повторяющимися словами.
    //Необходимо получить список всех уникальных слов, 
    //встречающихся в тексте, и вывести их на экран в алфавитном порядке.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "яблоко", "груша", "груша", "банан" };

            HashSet<string> uniqueWords = new HashSet<string>();

            foreach (string item in stringArray)
            {
                uniqueWords.Add(item);
            }

            List<string> sortedUniqueWords = uniqueWords.OrderBy(x => x).ToList();

            foreach (string item in sortedUniqueWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
