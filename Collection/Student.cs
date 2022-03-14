using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class Student
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public Int64 matricNumber { get; set; }
        public string sex { get; set; }
        public string state { get; set; }
        public string religion { get; set; }
        public string nationality { get; set; }


        // Student[] students = new Student[] { "funmi", "isaiah", "dammy", "ayo", "gabbum" }
        // create a class called student,give it properties, create a method that returns a value called student
        public void Getstudent()
        {
            Student student1 = new Student();
            student1.firstName = "johnson";
            student1.middleName = "ade";
            student1.surname = "Quadri";
            student1.age = 25;
            student1.sex = "male";
            student1.state = "lagos";
            student1.religion = "christianity";
            student1.matricNumber = 191062381;
            student1.nationality="nigerian";

            Student student2 = new Student();
            student2.firstName = "funmi";
            student2.middleName = "elizabeth";
            student2.surname = "Ade";
            student2.age = 24;
            student2.sex = "female";
            student2.state = "lagos";
            student2.religion = "muslim";
            student2.matricNumber = 191062382;
            student2.nationality = "England";

            Student student3 = new Student();
            student3.firstName = "dammy";
            student3.middleName = "bighead";
            student3.surname = "Basit";
            student3.age = 23;
            student3.sex = "male";
            student3.state = "shagamu";
            student3.religion = "islamic";
            student3.matricNumber = 191062383;
            student3.nationality = "chadian";

            Student student4 = new Student();
            student4.firstName = "Isaiah";
            student4.middleName = "ekpa";
            student4.surname = "dominic";
            student4.age = 22;
            student4.sex = "male";
            student4.state = "calabar";
            student4.religion = "pegan";
            student4.matricNumber = 191062384;
            student4.nationality = "southAfrican";

            Student student5 = new Student();
            student5.firstName = "Gabbum";
            student5.middleName = "Abah";
            student5.surname = "Ochayi";
            student5.age = 21;
            student5.sex = "male";
            student5.state = "Benue";
            student5.religion = "herbalist";
            student5.matricNumber = 191062385;
            student5.nationality = "europian";

            Student[] students = new Student[] { student1, student2, student3, student4, student5 };
            foreach(var student in students)
            {
                Console.WriteLine("Students details are {0} {1} {2} {3}", student.firstName, student.middleName, student.age, student.matricNumber);
            }
        }



    }
}
