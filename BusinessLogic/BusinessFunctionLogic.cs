using Book.businessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.BusinessLogic
{
    public class BusinessFunctionLogic: IBusinessFunctionLogic
    {
        private readonly ILogic logic;
        private bool? sortDescending;


        public BusinessFunctionLogic(Logic l)
        {
            this.logic = l;
        }

        public List<Book.model.Book> GetSortedBooks()
        {
            var books = logic.GetBooks();

            return sortDescending switch
            {
                null => books,
                true => books.OrderByDescending(book => book.Price).ToList(),
                false => books.OrderBy(book => book.Price).ToList()
            };
        }

        public Dictionary<string, List<Book.model.Book>> GroupByGenre()
            => logic.GetBooks().GroupBy(b => b.Genre).ToDictionary(g => g.Key, g => g.ToList());

        public List<Book.model.Book> FindByAuthor(string author)
            => logic.GetBooks().Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();

        public void SortByPrice()
        {
            sortDescending = sortDescending != true;
        }
    }
}
