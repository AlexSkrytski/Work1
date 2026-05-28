using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Library
{
    public class Book
    {
        public string title = string.Empty;
        public string author = string.Empty;
        public string year = string.Empty;

        public Book()
        {

            Console.WriteLine("Введите название книги:");
            title = Console.ReadLine()!;
            Console.WriteLine("Введите автора:");
            author = Console.ReadLine()!;
            Console.WriteLine("Введите год издания:");
            year = Console.ReadLine()!;
            
        }

    }
}
