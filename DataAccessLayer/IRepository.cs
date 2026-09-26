using Book.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class, IDomainObject
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        T? GetById(int id);
        List<T> GetAll();
    }
}
