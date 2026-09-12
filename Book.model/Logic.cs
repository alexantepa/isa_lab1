using System;
using System.Collections.Generic;
using System.Text;

namespace Book.model
{
    /// <summary>
    /// Класс бизнес-логики.
    /// </summary>

    public class Logic
    {
        public List<Book> books = new List<Book>();
        private int nextId = 1;
        public void CreatBook(string title, string author, string genre, int price)
        {
            Book book = new Book
            {
                id = nextId++,
                title = title,
                author = author,
                genre = genre,
                price = price
            };
            books.Add(book);
        }

        public void DeleteBook(int id)
        {
            Book? b = books.Find(x => x.id == id);
            if (b != null) books.Remove(b);
        }

        public void UpdateBook(int id, string newTitle, string newAuthor, string newGenre, int newPrice)
        {
            Book? b = books.Find(x => x.id == id);
            if (b != null)
            {
                b.title = newTitle;
                b.author = newAuthor;
                b.genre = newGenre;
                b.price = newPrice;
            }
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        /// <summary>
        /// Группировка книг по жанру
        /// </summary>
        public Dictionary<string, List<Book>> GroupByGenre()
        {
            return books.GroupBy(b => b.genre).ToDictionary(g => g.Key, g => g.ToList());
        }

        /// <summary>
        /// Поиск книг по автору
        /// </summary>
        public List<Book> FindByAuthor(string authorr)
        {
            return books.Where(b => b.author.Contains(authorr, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
