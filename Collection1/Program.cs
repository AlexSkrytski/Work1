namespace Collection1
{

    //Напишите метод, который принимает строку и возвращает Dictionary<char, int>, 
    //где ключ — это символ, а значение — сколько раз он встречается в строке. 
    //Пробелы игнорируйте.
    internal class Program
    {
        public Dictionary<char, int> CountCharactersLoop(string input)
        {
            var counts = new Dictionary<char, int>();

            if (string.IsNullOrEmpty(input)) return counts;

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c)) continue;

                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }

            return counts;

        }
        public static Dictionary<char, int> CountCharacters(string input)
        {

            if (string.IsNullOrEmpty(input))
                return new Dictionary<char, int>(); ;

            return input
                .Where(c => !char.IsWhiteSpace(c)) // Игнорируем пробелы и пробельные символы
                .GroupBy(c => c)
                .ToDictionary(group => group.Key, group => group.Count());

        }
        static void Main(string[] args)
        {

            Program dict = new Program();

            var count1 = dict.CountCharactersLoop("велосипед");

            foreach (KeyValuePair<char, int> item in count1)
            {
                Console.WriteLine($"Ключ: {item.Key}, Значение: {item.Value}");
            }

            Console.WriteLine();

            var count2 = CountCharacters("велосипед");

            foreach (KeyValuePair<char, int> item in count2)
            {
                Console.WriteLine($"Ключ: {item.Key}, Значение: {item.Value}");
            }

            
        }
    }
}
