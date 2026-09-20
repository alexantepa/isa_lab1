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
        public List<Book> busket = new List<Book>();
        private int nextId = 1;
        private bool flag = false;

        /// <summary>
        /// Создает книгу и добавляет ее в список
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="author">Автор</param>
        /// <param name="genre">Жанр</param>
        /// <param name="price">Цена</param>
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
        /// </summary>
        /// <param name="id">ID книги для удаления</param>
        public void DeleteBook(int id)
        {
            Book? b = books.Find(x => x.Id == id);
            if (b != null) books.Remove(b);
        }

        /// <summary>
        /// Изменение книги по ID
        /// </summary>
        /// <param name="id">ID книги для изменения</param>
        /// <param name="newTitle">Новое название</param>
        /// <param name="newAuthor">Имя нового автора</param>
        /// <param name="newGenre">Новый жанр</param>
        /// <param name="newPrice">Новая цена</param>
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
        /// Возвращает список всех книг
        /// </summary>
        /// <returns>Список книг</returns>
        public List<Book> GetBooks()
        {
            return books;
        }

        /// <summary>
        /// Группировка книг по жанру
        /// </summary>
        /// <returns>Словарь с группами книг</returns>
        public Dictionary<string, List<Book>> GroupByGenre()
        {
            return books.GroupBy(b => b.Genre).ToDictionary(g => g.Key, g => g.ToList());
        }

        /// <summary>
        /// Поиск книг по автору
        /// </summary>
        /// <param name="author">Автор</param>
        /// <returns>Книги автора</returns>
        public List<Book> FindByAuthor(string author)
        {
            return books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Добавление книги в корзину
        /// </summary>
        /// <param name="i">ID книги</param>
        public void AddToBusket(int i)
        {
            busket.Add(books.Find(x => x.Id == i));
        }

        /// <summary>
        /// Удаление всего сожержимого из корзины
        /// </summary>
        public void ClearBusket()
        {
            busket.Clear();
        }

        /// <summary>
        /// Сортирует список книг по цене. При каждом вызове меняет порядок сортировки (по возрастанию/по убыванию).
        /// </summary>
        public void SortByPrice()
        {
            flag = !flag;
            if (flag)
            {
                books = books.OrderBy(b => b.Price).ToList();
            }
            else
            {
                books = books.OrderByDescending(b => b.Price).ToList();
            }
        }
    }
}
