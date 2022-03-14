using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Loops
    {
        string[] student = new string[5] {"Isaiah", "Tosin", "Victoria", "Gabriel", "Clement"/*, "Dammy", "Prince", "Tunde", "Amaka", "Bunmi", "Mercy"*/ };
         
        public string getFirstStudent()
        {
            var getFirstStudent = student[0];
            return getFirstStudent;
        }
        public Array getAllStudent()
        {
            var getAllStudent = student;
            return getAllStudent;
        }
        public Array getLenght()
        {
            var getLenght = student;
            return getLenght;
        }
            



    }
}
