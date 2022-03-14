using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Exam
    {
        public string StudentName { get; set; }
        public int ExamId { get; set; } = 191062381;
        public int Score { get; set; }
        public string Subject { get; set; }

        List<Exam> examination = new List<Exam>();

        public bool RegisterExamScore(Exam score)
        {
            
            var ExamScore = examination.Count;
            if (ExamScore < 1)
            {
                examination.Add(score);
            }
            else
            {
                for (int i = 0; i < examination.Count; i++)
                {
                    examination.Add(score);
                    if (examination[i].Subject == score.Subject)
                    {
                        return false;
                    }
                    else
                    {
                        examination.Add(score);
                    }
                }
                
            }
            return true; 
        }
        public Exam GetExamScore(int index)
        {
            Exam score = examination[index];
            // Console.WriteLine("from the list of the students, exam scores are {0} {1} {2} {3}", score.StudentName, score.Subject, score.Score, score.ExamId);
            return score;
        }

    }
}
