using System.Diagnostics.Metrics;

namespace Collection1
{
    internal class Program
    {
        public static Dictionary<char, int> CountCharactersLoop(string input)
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

            foreach (KeyValuePair<char, int> item in counts)
            {
                Console.WriteLine($"Ключ: {item.Key}, Значение: {item.Value}");
            }

            return counts;

        }
        public static Dictionary<char, int> CountCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new Dictionary<char, int>(); ;

            var counts = input
                .Where(c => !char.IsWhiteSpace(c)) // Игнорируем пробелы и пробельные символы
                .GroupBy(c => c)
                .ToDictionary(group => group.Key, group => group.Count());

            foreach (KeyValuePair<char, int> item in counts)
            {
                Console.WriteLine($"Ключ: {item.Key}, Значение: {item.Value}");
            }

            return counts;

        }
        static void Main(string[] args)
        {
            CountCharactersLoop("велосипед");
            Console.WriteLine( );
            CountCharacters("велосипед");

        }
    }
}
