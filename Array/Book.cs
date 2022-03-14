using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Book
    {
        public string BookTitle { get; set; }
        public string author { get; set; }
        public string BookName { get; set; }
        public int Pages { get; set; }
        
        public List<Book> ListOfBooks()
        {
            List<Book> books = new List<Book>();

            Book novel = new Book();
            novel.BookTitle = "SecretGarden";
            novel.Pages = 150;

            Book poem = new Book();
            poem.BookTitle = "MyLife";
            poem.Pages = 150;

            Book dictionary = new Book();
            dictionary.BookTitle = "story";
            dictionary.Pages = 150;

            Book politics = new Book();
            politics.BookTitle = "All but a man";
            politics.Pages = 150;

            Book LibraryBooks = new Book();
            books.Add(novel);
            books.Add(politics);
            books.Add(poem);
            books.Add(dictionary);

            return books;
        }
        public Book StudentgetsTwoBooks(int index, int number)
        {
            Book LibraryBooks = new Book();
            var speed = LibraryBooks.books[index];
            return LibraryBooks;
        }
        public Book CallGetBook(Book book)
        {
            Library study = new Library();
            var studys = study.GetBook(book);
            return studys;
        }
        List<Book> books = new List<Book>();
        public bool RegisterBooks(Book bookss)
        {
            var BookCount = books.Count;
            if (BookCount < 1)
            {
                books.Add(bookss);
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    books.Add(bookss);
                    if (books[i].BookName == bookss.BookName)
                    {
                        return false;
                    }
                    else
                    {
                        books.Add(bookss);
                    }
                }
            }
            return true;
        }
        public Book GetOnlyOneBook(int index)
        {
            Book mathTestBook = new Book();
            mathTestBook.BookName = "Novella";
            var ListOfBooks = mathTestBook.ListOfBooks();
            
            Book bookss = ListOfBooks[index];
            return bookss;
        }
        //the following method is to get as much books as you want using the index before running your code.
        //it can get more than 2 books irrespective of the methodName already given.
        //you need to inherit atleast a value from (IComparable) to enable you use 
        public List<Book>  GetOnlyTwoBook(int Index)
        {
            Book testBook = new Book();
            var books = testBook.ListOfBooks().Take(Index);
            //for you to Sort through a List, you still have to convert (ListOfBook) to (ToList) before you use the (return) keyword finally.
            var finalBooks = books.ToList();
           // finalBooks.Sort();
            return finalBooks;
            //if you observe here, the return value is supposed to be (twobooks)only, but bcos the (List<Book> is IEnumerate) we need to convert ()twoBooks to ToList().
        }
        public void ConfirmUsingLambda()
        {
            Book book1 = new Book();
            var books = book1.GetOnlyTwoBook(4);
            var oneBok = books.Select(x => x).FirstOrDefault();
            Console.WriteLine("the first book picked is: {0} {1}", oneBok.BookTitle, oneBok.Pages);
        }
        



    } 
    
}
