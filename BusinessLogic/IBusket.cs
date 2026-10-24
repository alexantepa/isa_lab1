using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Book.BusinessLogic
{
    public interface IBusket
    {
        /// <summary>
        /// Добавление книги в корзину
        /// </summary>
        /// <param name="book">Экземпляр класса Book</param>
        public void Add(Book.model.Book book);

        /// <summary>
        /// Отчистка корзины
        /// </summary>
        public void Clear();

        /// <summary>
        /// Получение всех элементов из корзины
        /// </summary>
        /// <returns>Список книг, находящихся в корзине</returns>
        public List<Book.model.Book> GetBusket();

        /// <summary>
        /// Получение суммы всех товаров, находящихся в корзине
        /// </summary>
        /// <returns>Сумма товаров</returns>
        public int GetSum();
    }
}
