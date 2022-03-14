using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class StudentFactory
    {
       public List<student> ListOfStudents()
        {
            List<student> pupils = new List<student>();
            
            student student1 = new student();
            student1.FirstName = "Gabbum";
            student1.Sex = "Female";
            //student1.Score = 50;


            student student2 = new student();
            student2.FirstName = "Femi";
            student2.Sex = "Male";
            

            student student3 = new student();
            student3.FirstName = "Funmi";
            student3.Sex = "Male";
            

            student student4 = new student();
            student4.FirstName = "Dammy";
            student4.Sex = "Male";
            


            student student5 = new student();
            student5.FirstName = "Ayo";
            student5.Sex = "Male";




            //List<student> pupils = new List<student>();
            pupils.Add(student1);
            pupils.Add(student2);
            pupils.Add(student3);
            pupils.Add(student4);
            pupils.Add(student5);


            return pupils;
        }
        
        
        
    }
}
