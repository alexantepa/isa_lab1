using Book.businessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.BusinessLogic
{
    public interface IBusinessFunctionLogic
    {
        /// <summary>
        /// Получение отсортированного списка книг
        /// </summary>
        /// <returns>Список отсортированных книг</returns>
        public List<Book.model.Book> GetSortedBooks();

        /// <summary>
        /// Группировка книг по жанру
        /// </summary>
        /// <returns>Словарь с группами книг</returns>
        public Dictionary<string, List<Book.model.Book>> GroupByGenre();

        /// <summary>
        /// Поиск книг по автору
        /// </summary>
        /// <param name="author">Автор</param>
        /// <returns>Книги автора</returns>
        public List<Book.model.Book> FindByAuthor(string author);

        /// <summary>
        /// Сортирует список книг по цене. При каждом вызове меняет порядок сортировки (по возрастанию/по убыванию).
        /// </summary>
        public void SortByPrice();
    }
}
