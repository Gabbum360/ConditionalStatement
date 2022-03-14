using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Teacher
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int dateOfBirth { get; set; }
        public int age { get; set; }
        public Int64 staffId { get; set; }
        // ToViewHisDetails, MarkScripts,SetExams,SaveStaffRecords
        Teacher[] teacher = new Teacher[] {};
       public void ToViewDetails()
        {
            foreach(var item in teacher)
            {
                Console.WriteLine(item);
            }
            

        }
        public void MarkScripts()
        {

        }
        public void SetExams()
        {

        }
        public void SaveStaffRecords()
        {

        }
        public void Register()
        {
            
        }
    }
}
