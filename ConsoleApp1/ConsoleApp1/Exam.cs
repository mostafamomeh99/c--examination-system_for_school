using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam
    {
        public List<Question> Questions { get; set; } = new List<Question> { };
        public Exam(string subject="unknown", int numberofquestions=0, double totalgrade=0)
        {
            Subject = subject;
            Totalgrade = totalgrade;
            Numberofquestions = numberofquestions;
        }
        public string Subject { get; set; }
        public double Totalgrade { get; set; }
        public int Numberofquestions { get; set; }

        public void Addquestion(Question a)
        {
            Questions.Add(a);
        }
        public void DisplayQuestions( )
        {
          foreach(Question a in Questions)
            {
                Console.WriteLine(a.Display());
            }  
        }

        //public void questioninExam(Question a , int id)
        //{
            
        //}


    }
}
