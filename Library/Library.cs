using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library
    {
        private List<Book> books;
        public Library()
        {

            books = new List<Book>();

        }
        public void AddBook(Book book)
        {

            books.Add(book);
            Console.WriteLine($"Книга добавлена.");

        }
        public void RemoveBook()
        {
            Console.WriteLine("Введите название удаляемой книги:");
            string title = Console.ReadLine()!;
            // Ищем книгу, название которой совпадает (без учета регистра)
            int removedCount = books.RemoveAll(b => b.title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (removedCount > 0)
            {
                Console.WriteLine($"Книг(а) с названием '{title}' успешно удалена.");
            }
            else
            {
                Console.WriteLine($"Книга с названием '{title}' не найдена.");
            }
        }
    }
}
