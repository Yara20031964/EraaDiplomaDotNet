using System.Security.Cryptography.X509Certificates;

namespace Week3Part2
{
    internal class Program
    {
        class Book
        {
            string title;
            string Author;
            string ISBN;
            bool Availability = true;

            public Book(string title, string Author, string ISBN)
            {
                this.title = title;
                this.Author = Author;
                this.ISBN = ISBN;
            }

            //Setter
            public void SetTitle(string title)
            {
                this.title = title;
            }
            public void SetAuthor(string Author)
            {
                this.Author = Author;
            }
            public void SetISBN(string ISBN)
            {
                this.ISBN = ISBN;
            }            
            public void SetAvailability(bool Availability)
            {
                this.Availability = Availability;
            }            

            //Getter
            public string GetTitle()
            {
                return this.title;
            }
            public string GetAuthor()
            {
                return this.Author;
            }
            public string GetISBN()
            {
                return this.ISBN;
            }
            public bool GetAvailability()
            {
                return this.Availability;
            }

        }

        class Library
        {
            List<Book> books;

            public Library()
            {
                books = new List<Book>();
            }

            public void AddBook(Book book)
            {
                books.Add(book);
            }

            //Search by title
            public bool SearchBookByTitle(string title)
            {
                for( int i = 0; i < books.Count; i++)
                {
                    if(title == books[i].GetTitle())
                    {
                        return true;
                    }
                }
                return false;
            }

            //Search by author
            public bool SearchBookByAuthor(string Author)
            {
                for( int i = 0; i < books.Count; i++)
                {
                    if(Author == books[i].GetAuthor())
                    {
                        return true;
                    }
                }
                return false;
            }

            public void BorrowBook(string title)
            {
                bool found = false;
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].GetTitle() == title && books[i].GetAvailability())
                    {
                        books[i].SetAvailability(false);
                        found = true;
                    }
                }
                if (found)
                {
                    Console.WriteLine("The book has been succesfuly borrowed");
                }
                else
                {
                    Console.WriteLine("This book is not in the library");
                }
            }
            public void ReturnBook(string title)
            {
                bool returned = false;
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].GetTitle() == title && !books[i].GetAvailability())
                    {
                        books[i].SetAvailability(true);
                        returned = true;
                    }
                }
                if (returned)
                {
                    Console.WriteLine("The book has been succesfuly returned");
                }
                else
                {
                    Console.WriteLine("This book is not borrowed");
                }
            }


        }
        static void Main(string[] args)
        {
                Library library = new Library();
                // Adding books to the library
                library.AddBook(new Book("Gatsby", "F. Scott Fitzgerald", "9780743273565"));
                library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
                library.AddBook(new Book("1984", "George Orwell", "9780451524935"));
                // Searching and borrowing books
                Console.WriteLine("Searching and borrowing books...");
                library.BorrowBook("Gatsby");
                library.BorrowBook("1984");
                library.BorrowBook("Harry Potter"); // This book is not in the library
                                                    // Returning books
                Console.WriteLine("\nReturning books...");
                library.ReturnBook("Gatsby");
                library.ReturnBook("Harry Potter"); // This book is not borrowed
            }
    }
}
