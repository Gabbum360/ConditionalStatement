using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Exam
    {
        public string StudentName { get; set; }
        public int ExamId { get; set; } = 191062381;
        public int Score { get; set; }
        public string Subject { get; set; }

        Exam[] subjects = new Exam[4];
        public bool ExamScore(Exam score)
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                if (i==0)
                {
                    subjects[0] = score;
                    return true;
                }
                else
                {
                    subjects[i] = score;
                    return true;
                }
            } 
            return true;
        }
        public void GetStudentExamScore(int index)
        {
            Exam Score = subjects[index];
            Console.WriteLine("students exam details are: {0} {1} {2} {3}", Score.StudentName, Score.Subject, Score.Score, Score.subjects);

        }
    }
}
