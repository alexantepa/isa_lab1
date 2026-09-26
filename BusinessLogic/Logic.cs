using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.businessLogic
{
    /// <summary>
    /// Класс бизнес-логики.
    /// </summary>

    public class Logic: IDisposable
    {
        private readonly IRepository<Book.model.Book> repository;
        private readonly AppDbContext? ownedContext;

        public Logic()
        {
            ownedContext = new AppDbContext();
            repository = new EntityRepository<Book.model.Book>(ownedContext);
        }
        public Logic(IRepository<Book.model.Book> repository) { this.repository = repository; }

        public void Dispose()
        {
            ownedContext?.Dispose();
        }


        public List<Book.model.Book> busket = new List<Book.model.Book>();
        private int nextId = 1;
        private bool? sortDescending = null;

        /// <summary>
        /// Создает книгу и добавляет ее в список
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="author">Автор</param>
        /// <param name="genre">Жанр</param>
        /// <param name="price">Цена</param>
        public void CreatBook(string title, string author, string genre, int price)
        {
            var book = new Book.model.Book { Title = title, Author = author, Genre = genre, Price = price };
            repository.Add(book);
        }

        /// <summary>
        /// Удаление книги по ID
        /// </summary>
        /// <param name="id">ID книги для удаления</param>
        public void DeleteBook(int id)
        {
            repository.Delete(id);
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
            var book = repository.GetById(id);
            if (book == null) return;

            book.Title = newTitle;
            book.Author = newAuthor;
            book.Genre = newGenre;
            book.Price = newPrice;
            repository.Update(book);
        }

        /// <summary>
        /// Возвращает список всех книг
        /// </summary>
        /// <returns>Список книг</returns>
        public List<Book.model.Book> GetBooks()
        {
            var books = repository.GetAll();
            return sortDescending switch
            {
                null => books,
                true => books.OrderByDescending(b => b.Price).ToList(),
                false => books.OrderBy(b => b.Price).ToList()
            };
        }

        /// <summary>
        /// Группировка книг по жанру
        /// </summary>
        /// <returns>Словарь с группами книг</returns>
        public Dictionary<string, List<Book.model.Book>> GroupByGenre()
            => GetBooks().GroupBy(b => b.Genre).ToDictionary(g => g.Key, g => g.ToList());


        /// <summary>
        /// Поиск книг по автору
        /// </summary>
        /// <param name="author">Автор</param>
        /// <returns>Книги автора</returns>
        public List<Book.model.Book> FindByAuthor(string author)
            => GetBooks().Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();


        /// <summary>
        /// Добавление книги в корзину
        /// </summary>
        /// <param name="i">ID книги</param>
        public void AddToBusket(int id)
        {
            var book = GetBooks().Find(x => x.Id == id);
            if (book != null) busket.Add(book);
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
            sortDescending = sortDescending != true;
        }
    }
}
