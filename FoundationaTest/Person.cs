using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationaTest
{
    class Person
    {
        
        
        public string Color { get; set; }
        public int Age { get; set; }
        public bool Height { get; set; }



        

        public void Dance()
        {
            Console.WriteLine("Hello! i can Dance in all steps");
        }
        public int CalculateAge(int givenDate, int dateOfBirth)
        {
            Person John = new Person();
            var age = givenDate - dateOfBirth;
            return age ;
            
            int Age = John.CalculateAge(2021, 1996);
            Console.WriteLine("John is {0}",Age);
            Console.WriteLine("John is Dancing");
        }
        public bool doPersonHaveHeight( Decimal Height)
        {
            if (Height > 200)
                return false;
            else
                return true;
            Console.WriteLine("what is your Height?");
            int  age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
