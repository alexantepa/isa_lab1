using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.BusinessLogic
{
    public interface ILogic
    {
        /// <summary>
        /// Создает книгу и добавляет ее в список
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="author">Автор</param>
        /// <param name="genre">Жанр</param>
        /// <param name="price">Цена</param>
        public void CreatBook(string title, string author, string genre, int price);

        /// <summary>
        /// Удаление книги по ID
        /// </summary>
        /// <param name="id">ID книги для удаления</param>
        public void DeleteBook(int id);

        /// <summary>
        /// Изменение книги по ID
        /// </summary>
        /// <param name="id">ID книги для изменения</param>
        /// <param name="newTitle">Новое название</param>
        /// <param name="newAuthor">Имя нового автора</param>
        /// <param name="newGenre">Новый жанр</param>
        /// <param name="newPrice">Новая цена</param>
        public void UpdateBook(int id, string newTitle, string newAuthor, string newGenre, int newPrice);

        /// <summary>
        /// Возвращает список всех книг
        /// </summary>
        /// <returns>Список книг</returns>
        public List<Book.model.Book> GetBooks();

        public List<model.Book> GetSortedBooks();

        public Dictionary<string, List<Book.model.Book>> GroupByGenre();

        public List<model.Book> FindByAuthor(string author);

        public void SortByPrice();

        public void Add(Book.model.Book book);

        public void Clear();

        public IReadOnlyList<Book.model.Book> GetBusket();

        public int GetSum();


    }
}
