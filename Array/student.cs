using System.Collections.Generic;
using System.Linq;

namespace Array
{
    public class student
    {
        public string FirstName { get; set; }
        public int StudentId { get; set; }=191062381;
        public string StudentLastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public bool Uniform { get; set; }
        public string DateOfBirth { get; set; }
        public string StudentName { get; set; }
      //  public int Score { get; set; }

       public static List<student> students = new List<student>();
        //before you loop through a list, make sure you check if there are/is any available student. and the "List<T>" when creating an "instance" should be under the instances and not above it 
        public bool RegisterStudents(student pupil)
        {
            //List<Student> students = new List<Student>();
            // students.Add(pupils);
            var studentCount = students.Count;
            if (studentCount < 1)
            {
                students.Add(pupil);
            }
            else
            {

                for (int i = 0; i < students.Count; i++)
                {

                    students.Add(pupil);
                    if (students[i].FirstName == pupil.FirstName)
                    {
                        return false;
                    }
                    else
                    {
                        students.Add(pupil);
                    }
                }
            }
            return true;
        }
        public void GetStudents()
        {
            student pupil = new student();
            System.Console.WriteLine("registered student details are: {0} {1} {2}", pupil.FirstName, pupil.Sex, pupil.StudentId);
        }
        public List<Book> CallAllStudentBooks()
        {
            Book book1 = new Book();
            var book = book1.ListOfBooks();
            return book;
        }


        //public List<Book> GettwoBooksOnly()
        //{
        //    Book homeEcons = new Book();
        //    homeEcons.BookName = "Poem";
        //    var studys = homeEcons.ListOfBooks();

        //    Book socialStudy = new Book();
        //    socialStudy.BookName = "Poem";
        //    var study = socialStudy.ListOfBooks();
        //    return studys;

        //}

    }
}