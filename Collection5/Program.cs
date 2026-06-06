using System.Text.RegularExpressions;

namespace Collection5
{

    //Загрузите длинный текст, очистите его от знаков препинания
    //и приведите к нижнему регистру.Используя HashSet<string>,
    //найдите все уникальные слова и выведите их на экран.
    internal class Program
    {
        static void Main()
        {
            // 1. Исходный длинный текст (пример)
            string text = "Пример текста, который содержит много слов. Текст нужно очистить, " +
                          "привести к нижнему регистру и найти все уникальные слова! " +
                          "Слова могут повторяться, но в HashSet они будут уникальными.";

            // 2. Приведение к нижнему регистру
            string lowerCaseText = text.ToLower();

            // 3. Удаление знаков препинания и разбивка на слова
            // Регулярное выражение \p{P} удаляет все знаки препинания. 
            // \s+ используется для разделения слов по пробелам.
            string[] words = Regex.Split(lowerCaseText, @"[\p{P}\s]+");

            // 4. Поиск уникальных слов с помощью HashSet
            HashSet<string> uniqueWords = new HashSet<string>();

            foreach (var word in words)
            {
                // Фильтруем пустые строки, которые могут возникнуть из-за двойных пробелов или знаков препинания
                if (!string.IsNullOrWhiteSpace(word))
                {
                    uniqueWords.Add(word);
                }
            }

            // 5. Вывод результатов на экран
            Console.WriteLine($"Всего уникальных слов: {uniqueWords.Count}\n"); // \n - пустая строка (Enter)
            Console.WriteLine("Список уникальных слов:");
            foreach (var word in uniqueWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
