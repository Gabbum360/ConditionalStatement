using System;
using System.Linq;
using System.Collections.Generic;

namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();
            book1.ConfirmUsingLambda();
            //to get two or more books. note: these books must be available in the BookList.
            var books = book1.GetOnlyTwoBook(4);
            //another way you can pick a book is the (select) method. using (lambda expression such as (X => X) as seen below.
            var oneBok = books.Select(x => x).FirstOrDefault();
            Console.WriteLine("the first book picked is: {0} {1}", oneBok.BookTitle, oneBok.Pages);
            //to get all the books.
            var allBooks = books.Select(x => x).ToList();
            foreach (var item in allBooks)
            {
                Console.WriteLine(item.BookTitle);
            }
            //you can also get a particular book by specifying the book title inside the (Lambda) expression and use the (select())
            var getBookByTitle = books.Where(x => x.BookTitle == "MyLife").Select(x => x).FirstOrDefault();
            Console.WriteLine("book fould with the given name is: {0} which has {1} pages", getBookByTitle.BookTitle, getBookByTitle.Pages);
          //  book1.GetOnlyTwoBook(2).Sort();
            //foreach (var item in books)
            //{
            //    Console.WriteLine("books picked are: {0}", item.BookTitle, item.Pages);
            //}
            
            //var librarybook = books.GetOnlyOneBook(0);
            //Console.WriteLine("student picked : {0}",librarybook.BookTitle);
            // student book = new student();
            // var schoolBook = book.GettwoBooksOnly();
            //Book TestBook = new Book();
            //Book poem = new Book();
            //poem.BookTitle = "MyLife";
            //poem.Pages = 150;

            //Book dictionary = new Book();
            //dictionary.BookTitle = "story";
            //dictionary.Pages = 150;
            //var testBooks = book.GettwoBooksOnly();
            //book.GettwoBooksOnly();
            //foreach (var item in schoolBook)
            //{
            //    Book TestBook = new Book();
            //    Book poem = new Book();
            //    poem.BookTitle = "MyLife";
            //    poem.Pages = 150;

            //    Book dictionary = new Book();
            //    dictionary.BookTitle = "story";
            //    dictionary.Pages = 150;
            //    var study = TestBook.GetOnlyTwoBook();
            //    Console.WriteLine("student books are: {0} {1}", item.BookName, item.BookTitle);
            //}
            //Library book = new Library();
            //var books = book.GetAllBooks();
            //book.GetAllBooks();
            //student pupil = new student();
            //var books = pupil.CallAllStudentBooks();
            //foreach (var item in books)
            //{
            //    student student1 = new student();
            //    student1.FirstName = item.BookTitle;
            //    Console.WriteLine("student books are: {0} {1} {2}", item.BookTitle, item.Pages, item.author);
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < books.Count; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //StudentFactory student = new StudentFactory();
            //var students = student.ListOfStudents();
            //Exam examscores = new Exam();
            //Book book = new Book();
            //var books = book.ListOfBooks();

            //foreach (var item in books)
            //{
            //    Book Books = new Book();
            //    Books.BookName = item.BookTitle;
            //    Books.BookName = "novella";
            //    Books.BookTitle = "poem";
            //    Books.Pages = 130;
            //    Books.CallGetBook(Books);

            //    Console.WriteLine("list of books are: {0} {1} {2}", Books.BookTitle, Books.Pages, Books.BookName);
            //}


            //foreach (var item in students)
            //{
            //    Exam examScore = new Exam();
            //    examScore.StudentName = item.FirstName;
            //    examScore.Score = 4;
            //    examScore.RegisterExamScore(examScore);
            //    var exam =  examScore.GetExamScore(0);

            //    Console.WriteLine("student registered details are: {0} {1} {2} {3}", item.FirstName, item.Sex, item.StudentId, exam.Score);

            //}
            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //student student1 = new student();
            //student1.FirstName = "Gabbum";
            //student1.Sex = "Female";
            //var student = student1.RegisterStudents(student1);

            //student student2 = new student();
            //student2.FirstName = "Gabbum";
            //student2.Sex = "Male";
            //student2.RegisterStudents(student2);
            //student2.GetStudents();
            //List<string> food = new List<string>();
            //food.Add("rice");
            //food.Add("beans");
            //food.Add("yam");
            //food.Add("spagh");

            //foreach (var item in food)
            //{ 
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < food.Count; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //List<student> pupils = new List<student>();
            //student student1 = new student();

            //pupils.Add(student1);
            //Student students3 = new Student();
            //students3.StudentName = students3.FirstName;
            //students3.Sex = "Male";
            //students3.RegisterStudents(students3);
            //students3.GetStudents();





            Console.ReadLine();
        }

    }
}
