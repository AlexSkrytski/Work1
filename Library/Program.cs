namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library myLibrary = new Library();
            myLibrary.AddBook(new Book());
            myLibrary.AddBook(new Book());
            myLibrary.AddBook(new Book());

            myLibrary.RemoveBook();

        }
    }
}
