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

        /// <summary>
        /// Создание новой книги и добавление её в список
        /// <param name="title">Название клиента</param>
        /// <param name="author">Имя автора</param>
        /// <param name="genre">Жанр книги</param>
        /// <param name="price">Цена книги</param>
        /// </summary>
        public void CreatBook(string title, string author, string genre, int price)
        {
            Book book = new Book
            {
                Id = nextId++,
                Title = title,
                Author = author,
                Genre = genre,
                Price = price
            };
            books.Add(book);
        }

        /// <summary>
        /// Удаление книги по ID
        /// <param name="id">ID книги</param>
        /// </summary>
        public void DeleteBook(int id)
        {
            Book? b = books.Find(x => x.Id == id);
            if (b != null) books.Remove(b);
        }

        /// <summary>
        /// Изменение книги по ID
        /// <param name="id">ID книги для изменения</param>
        /// <param name="newTitle">Новое название</param>
        /// <param name="newAuthor">Имя нового автора</param>
        /// <param name="newGenre">Новый жанр</param>
        /// <param name="newPrice">Новая цена</param>
        /// </summary>
        public void UpdateBook(int id, string newTitle, string newAuthor, string newGenre, int newPrice)
        {
            Book? b = books.Find(x => x.Id == id);
            if (b != null)
            {
                b.Title = newTitle;
                b.Author = newAuthor;
                b.Genre = newGenre;
                b.Price = newPrice;
            }
        }

        /// <summary>
        /// Чтение всех книг
        /// </summary>
        public List<Book> GetBooks()
        {
            return books;
        }

        /// <summary>
        /// Группировка книг по жанру
        /// </summary>
        public Dictionary<string, List<Book>> GroupByGenre()
        {
            return books.GroupBy(b => b.Genre).ToDictionary(g => g.Key, g => g.ToList());
        }

        /// <summary>
        /// Поиск книг по автору
        /// <param name="author">Имя автора на поиска</param>
        /// </summary>
        public List<Book> FindByAuthor(string author)
        {
            return books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}
