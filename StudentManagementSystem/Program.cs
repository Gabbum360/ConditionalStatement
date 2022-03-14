using System;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student();
            Student1.firstName = "Gabriel ";
            Student1.Register(Student1);

            Student student2 = new Student();
            student2.firstName = "Femi ";
            student2.Register(student2);

            Student student3 = new Student();
            student3.firstName = "Funmi";
            student3.Register(student3);

            Student student4 = new Student();
            student4.firstName = "Ayo";
            student4.Register(student4);

            //student4.GetStudent(0);
            Exam studentScore1 = new Exam();
            studentScore1.StudentName = Student1.firstName;
            studentScore1.Subject = "English";
            studentScore1.Score = 55;
            studentScore1.ExamScore(studentScore1);
           

            Exam studentScore2 = new Exam();
            studentScore2.StudentName = student2.firstName;
            studentScore2.Subject = "french";
            studentScore2.Score = 40;
            studentScore2.ExamScore(studentScore2);
           

            Exam studentScore3 = new Exam();
            studentScore3.StudentName = student3.firstName;
            studentScore3.Subject = "maths";
            studentScore3.Score = 72;
            studentScore3.ExamScore(studentScore3);
           

            Exam studentScore4 = new Exam();
            studentScore4.StudentName = student4.firstName;
            studentScore4.Subject = "econs";
            studentScore4.Score = 100;
            studentScore4.ExamScore(studentScore4);

            studentScore4.GetStudentExamScore(0);
            studentScore1.GetStudentExamScore(1);
            studentScore2.GetStudentExamScore(2);
            studentScore3.GetStudentExamScore(4);
            Console.ReadLine();
           // Console.WriteLine("Hello World!");
        }
    }
}
