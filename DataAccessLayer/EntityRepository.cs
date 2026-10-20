using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class EntityRepository<T> : IRepository<T> where T : class, Book.model.IDomainObject
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public EntityRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        
        public void Add(T item) { _dbSet.Add(item); _context.SaveChanges(); }

        public void Delete(int id)
        {
            var item = _dbSet.Find(id);
            if (item != null) { _dbSet.Remove(item); _context.SaveChanges(); }
        }

        public List<T> GetAll() => _dbSet.AsNoTracking().ToList();

        public T? GetById(int id) => _dbSet.Find(id);

        public void Update(T item) { _dbSet.Update(item); _context.SaveChanges(); }
    }
}
