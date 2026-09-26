using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class AppDbContext: DbContext
    {
        public DbSet<Book.model.Book> Books { get; set; } = null!;
        private readonly string _connectionString;

        public AppDbContext(string connectionString = "Data Source=books.db")
        {
            _connectionString = connectionString;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }
    }
}
