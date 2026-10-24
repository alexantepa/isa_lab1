using System;
using System.Collections.Generic;
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
    }
}
