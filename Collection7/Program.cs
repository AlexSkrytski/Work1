namespace Collection7
{

    //Создать программу, которая позволяет хранить пары «Имя — Номер телефона».
    //Реализовать возможность добавления нового контакта и быстрого поиска 
    //номера по имени.Идеальная коллекция: Dictionary<TKey,
    //TValue> — для работы по принципу "ключ-значение".
    internal class Program
    {                    
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();

            phoneBook.Add("Иван", "+3751111111");

            phoneBook.Add("Николай", "+3752222222");

            phoneBook.Add("Евгений", "+3753333333");

            phoneBook.Add("Руслан", "+3754444444");

            Console.WriteLine("Поиск по имени:");

            string nameSearch = Console.ReadLine()!;

            if (phoneBook.TryGetValue(nameSearch, out string foundItem))
            {
                Console.WriteLine($"Номер телефона {nameSearch}: {foundItem}");
            }
            else
            {
                Console.WriteLine("Абонент не найден.");
            }
        }
    }
}
