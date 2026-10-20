using Book.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class, IDomainObject
    {
        /// <summary>
        /// Добавление элемента в бд
        /// </summary>
        /// <param name="item">Элемент</param>
        void Add(T item);

        /// <summary>
        /// Изменение элемента в бд
        /// </summary>
        /// <param name="item">Элемент</param>
        void Update(T item);

        /// <summary>
        /// Удаление элемента из бд по ID
        /// </summary>
        /// <param name="id">ID элемента</param>
        void Delete(int id);

        /// <summary>
        /// Получение элемента из бд по ID
        /// </summary>
        /// <param name="id">ID элемента</param>
        /// <returns></returns>
        T? GetById(int id);

        /// <summary>
        /// Получение всех элементов из бд
        /// </summary>
        /// <returns>Список всех элементов</returns>
        List<T> GetAll();
    }
}
