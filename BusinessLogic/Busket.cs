using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.BusinessLogic
{
    public class Busket: IBusket
    {
        public List<Book.model.Book> busket;
        public int sum = 0;

        public Busket() {
            busket = new List<Book.model.Book>();
        }
        public void Add(Book.model.Book book)
        {
            if (book != null)
            {
                busket.Add(book);
                sum += book.Price;
            }
        }

        public void Clear()
        {
            busket.Clear();
            sum = 0;
        }
    }
}
