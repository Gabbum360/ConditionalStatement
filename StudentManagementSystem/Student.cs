using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Student
    {
        public string firstName { get; set; }
        public string middleName { get; set; } = "Ade";
        public string lastName { get; set; }
        public int dateOfBirth { get; set; } = 1996;
        public string Registerstudent { get; set; }
        public int age { get; set; } = 25;
        public Int64 matricNumber { get; set; }

        Student[] students = new Student[4];
        public bool Register(Student pupil)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (i == 0)
                {
                    students[0] = pupil;
                }
                else
                {
                    students[i] = pupil;
                }
            }
            return true;
            
        }
        public void GetStudent(int index)
        {
            Student pupil = students[index];
            Console.WriteLine("students registered details are: {0} {1} {2} {3}", pupil.firstName, pupil.age, pupil.dateOfBirth, pupil.middleName);
        }

        public void CheckExamResult()
        {

        }
        public void TakeExams()
        {

        }
        public void Write()
        {

        }
    }
}
