using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops Diet = new Loops();
            //Diet.CallStringItem();
            //Diet.foodList();
            //Diet.dietSort();
            //string name = "Gabriel";
            //string surname = "Ochayi";
            //string fullName = (name + surname); 
            //Console.WriteLine("my fullname is " +name+surname);
            //var Student = Diet.getAllStudent();
            //foreach (string item in Student)
            //{
            //    Console.WriteLine(item);
            //}
            //for ( int item=5; item<=Student.Length; item++ )
            //{
            //    Console.WriteLine(Student.Length);
            //}
           // Console.WriteLine(Student.Length);
            //int[] numbers = new int[4] { 70, 50, 1, 5 };
            //numbers[0] = 5;
            //numbers[1] = 2;
            //numbers[2] = 4;
            //numbers[3] = 1;

            //Array.Sort(numbers);
            //foreach(int item in numbers)
            //Console.WriteLine(item);

            // find the Lastindex number of an Array
            //int index1 = Array.LastIndexOf(numbers, 1, 4);
            //Console.WriteLine(index1);

            //int index1 = Array.IndexOf(numbers, 3, 4);
            //    Console.WriteLine(index1);

            Student pupils=new Student();
            pupils.Getstudent();
            //Array.Sort();
            

            Console.ReadLine();
        }

    }
    
}
