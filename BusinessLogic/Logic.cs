using Book.BusinessLogic;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.businessLogic
{
    /// <summary>
    /// Класс бизнес-логики.
    /// </summary>

    public class Logic: ILogic
    {
        private readonly IRepository<Book.model.Book> repository;

        public Logic(IRepository<Book.model.Book> repository) { this.repository = repository; }

        public void CreatBook(string title, string author, string genre, int price)
        {
            var book = new Book.model.Book { Title = title, Author = author, Genre = genre, Price = price };
            repository.Add(book);
        }

        public void DeleteBook(int id)
        {
            repository.Delete(id);
        }

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

        public List<Book.model.Book> GetBooks()
        {
            return repository.GetAll();
        }
    }
}
