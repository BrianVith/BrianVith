using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Controller
    {
        private List<Book> books;
        private List<Amulet> amulets; 

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        
        public List<Amulet> Amulets
        {
            get { return amulets; }
            set { amulets = value; }
        }


        public Controller()
        {
            books = new List<Book>();
            amulets = new List<Amulet>();
        }

        public void AddToList(Book book)
        {
            books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            amulets.Add(amulet);
        }

    }
}
