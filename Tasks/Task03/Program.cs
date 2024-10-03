using System.Diagnostics;

namespace Task03
{
    public class Library
    {
        List<Book> collectionBooks = new();

        public Library() { }
        public Library(List<Book> collectionBooks)
        {
            this.collectionBooks = collectionBooks;
        }
        public void AddBook(Book book)
        {
            this.collectionBooks.Add(book);
            Console.WriteLine($"{book.title} added");
        }
        public bool Search(string bookTitle)
        {
            for (int i = 0; i < collectionBooks.Count; i++)
            {
                if (collectionBooks[i].title == bookTitle)
                {
                    Console.WriteLine($"The {bookTitle} is available");
                    return true;
                }

            }
            Console.WriteLine($"the {bookTitle} is not available");
            return false;
        }
        public bool BorrowBook(string bookTitle)
        {
            for (int i = 0; i < collectionBooks.Count; i++)
            {
                if (collectionBooks[i].title == bookTitle)
                {
                    collectionBooks[i].availability = true;
                    Console.WriteLine($"The book borrowed");
                    return true;
                }
            }
            Console.WriteLine("this book is not in library");
            return false;
        }
        public bool ReturnBook(string bookTitle)
        {
            for (int i = 0; i < collectionBooks.Count; i++)
            {
                if (collectionBooks[i].title == bookTitle)
                {
                    collectionBooks[i].availability = false;
                    Console.WriteLine($"the {bookTitle} returned");
                    return true;
                }
            }
            Console.WriteLine($"The {bookTitle} is not borrowed");
            return false;
        }
    }
    public class Book
    {
        public string title;
        public string author;
        public string iSBN;
        public bool availability;

        public Book(string title, string author, string iSBN)
        {
            this.title = title;
            this.author = author;
            this.iSBN = iSBN;
        }
        public Book() { }
    }
    internal class Program
    {
        static void Main()
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.Search("1984");
            library.Search("Harry Potter");
            library.BorrowBook("The Great Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("The Great Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed

            Console.ReadLine();
        }
    }
}
