using System;
using System.Collections.Generic;
using System.Text;

namespace Book.model
{
    /// <summary>
    /// Provides logic for managing books.
    /// </summary>
    internal class Logic
    {
        int k;
        public List<Book> books = new List<Book>();
        public Book CreatBook(int id, string title, string author, string genre, int price)
        {
            Book book = new Book
            {
                id = id,
                title = title,
                author = author,
                genre = genre,
                price = price
            };
            books.Add(book);
            return book;//ЗАЧЕМИ. НАДО УБРАТЬ И ИЗМЕНИТЬ НА ВОЙД
        }

        public void DeleteBook(int id)
        {
            Book b = books.Find(x => x.id == id);
            if (b != null) books.Remove(b);
        }

        public void UpdateBook(Book book, string newTitle, string newAuthor, string newGenre, int newPrice)
        {
            book.title = newTitle;
            book.author = newAuthor;
            book.genre = newGenre;
            book.price = newPrice;
            // You can add additional logic here, such as saving the updated book to a database or a collection.
        }

        public void ReadBook(Book book)
        {
            Console.WriteLine($"ID: {book.id}, Title: {book.title}, Author: {book.author}, Genre: {book.genre}, Price: {book.price}");
        }

        public void GroupByGenre(List<Book> books)
        {
            //var groupedBooks = new Dictionary<string, List<Book>>();
            //foreach (var book in books)
            //{
            //    if (!groupedBooks.ContainsKey(book.genre))
            //    {
            //        groupedBooks[book.genre] = new List<Book>();
            //    }
            //    groupedBooks[book.genre].Add(book);
            //}
            //foreach (var genre in groupedBooks.Keys)
            //{
            //    Console.WriteLine($"Genre: {genre}");
            //    foreach (var book in groupedBooks[genre])
            //    {
            //        Console.WriteLine($"  ID: {book.id}, Title: {book.title}, Author: {book.author}, Price: {book.price}");
            //    }
            //}
        }

        public void GroupeByAuthor(List<Book> books)
        {
            //var groupedBooks = new Dictionary<string, List<Book>>();
            //foreach (var book in books)
            //{
            //    if (!groupedBooks.ContainsKey(book.author))
            //    {
            //        groupedBooks[book.author] = new List<Book>();
            //    }
            //    groupedBooks[book.author].Add(book);
            //}
            //foreach (var author in groupedBooks.Keys)
            //{
            //    Console.WriteLine($"Author: {author}");
            //    foreach (var book in groupedBooks[author])
            //    {
            //        Console.WriteLine($"  ID: {book.id}, Title: {book.title}, Genre: {book.genre}, Price: {book.price}");
            //    }
            //}
        }
    }
}
