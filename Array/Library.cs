using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Library
    {
        public int NUmberOfBooks { get; set; }
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }

        
        public Book GetBook(Book book)
        {
            Library books = new Library();
           // var TotalBooks = book.ListOfBooks();
            return book;
        }
        public List<Book> GetAllBooks()
        {
            Book book1 = new Book();
            Books = book1.ListOfBooks();
            return Books;
        }
    }
    
}
