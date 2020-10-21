using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class BookRepository
    {
        private List<Book> books;

        public BookRepository()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            foreach (Book b in books)
            {
                if (b.ItemId == itemId)
                {
                    return b;
                }
            }

            return null;
        }

        public double GetTotalValue()
        {
            double sum = 0;

            foreach (Book b in books)
            {
                sum += Utility.GetValueOfMerchandise(b);
            }

            return sum;
        }
    
    }
}
