using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.BusinessLogic
{
    public class Busket: IBusket
    {
        private List<Book.model.Book> busket;
        private int sum = 0;

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

        public List<Book.model.Book> GetBusket()
        {
            List<Book.model.Book> b = new List<Book.model.Book>();
            foreach (var item in busket)
            {
                b.Add(item);
            }
            return b;
        }

        public int GetSum() => sum;
    }
}
