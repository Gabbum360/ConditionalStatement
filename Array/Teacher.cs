using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        public int Age { get; set; }
        public int StaffId { get; set; }
       // public string TeacherName { get; set; }
        //public string TeacherName { get; set; }

        public student GetStudentRecord(student pupil)
        {
            student mathTeacher = new student();
            var teacher = mathTeacher.RegisterStudents(pupil);
            //student pupil = mathTeacher[]
            //Teacher mathTeacher = new Teacher();
            //var Getrecord = mathTeacher.TeacherName;
            return mathTeacher;
        }
        
        
    }
}
