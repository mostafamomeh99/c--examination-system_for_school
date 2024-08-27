using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exaninationsystem
    {
     public  List<Exam> Exams { get; set; } = new List<Exam>() { };
        public List<Student> Students { get; set; } = new List<Student>() { };
        
        public void enrollstudent(Student a)
        {
            Students.Add(a);
        }

        public void displayallstudents()
        {
            foreach (Student a in Students) 
            { Console.WriteLine(a); }
        }

        public void MakeExam()
        {
            try
            {
                Console.WriteLine("are you want to make exam ? (y) yes / press any thing to escape");
                string inputfirst = Console.ReadLine();
                if (inputfirst.ToLower()=="y")
                {
                    Console.Write("enter number of questions in exam :");
                    int numberofquestion = int.Parse(Console.ReadLine());
                    Console.Write("which subject in exam :");
                    string subjrctinput = Console.ReadLine().ToLower();
                    Exam firstexam = new Exam(subjrctinput, numberofquestion);
                    Console.Write("let's start to add question");
                    for (int i = 0; i < numberofquestion; i++)
                    {
                        Console.WriteLine("choose type of question\n1- true or false\n2- choose");
                        string type = Console.ReadLine();
                        Console.WriteLine("enter question");
                        string body = Console.ReadLine().ToLower();
                        Console.WriteLine("enter answer");
                        string answer = Console.ReadLine().ToLower();
                        Console.WriteLine("enter mark of question");
                        int mark = int.Parse(Console.ReadLine());
                        firstexam.Totalgrade += mark;
                        if (type == "1")
                        {
                            Question question1 = new TrueorFalse(body, answer, mark);
                            firstexam.Addquestion(question1);
                        }
                        else if (type == "2")
                        {
                            Choose question2 = new Choose(body, answer, mark);
                            question2.Addchoices();
                            firstexam.Addquestion(question2);
                        }
                    }

                    //return firstexam;
                    Exams.Add(firstexam);
                    Console.WriteLine("---Exams are ready !!");
                }
                else { Console.WriteLine("---Exam not completed !!"); }
            }



            catch (FormatException e)
            {
                Console.WriteLine("---not valid answer");
            }

        }

        public void GetExams()
        {
            foreach (var item in Exams)
            {
                item.DisplayQuestions();
            }
        }


        public void TakeExam()
        {
           
      try { 
         Console.WriteLine("enter your id");
         int inputid=int.Parse(Console.ReadLine());
        Student founded = Students.Find(el => el.Id == inputid);
       if (founded != null)
       {
         Console.WriteLine("enter subject");
         string inputsubject = Console.ReadLine().ToLower();
        //use IEnumerable where to find all create exams of subject
         IEnumerable<Exam> foundedexams = Exams.Where(p => p.Subject.ToLower() == inputsubject.ToLower());
          if (founded.State_of_exam.Contains(inputsubject))
          { Console.WriteLine("---you already enter this exam !"); }
                    
  
      // check if IEnumerable is not null
         else if (!foundedexams.Any())
        { Console.WriteLine("---there is no exams for this subject now"); }
  
     else
        {
         List<Exam> foundedlist = foundedexams.ToList();
        // generate random number for index to choose random one from many exsam for one subject 
           Random random = new Random();
           int randomIndex = random.Next(foundedlist.Count);
           //CurrentExam
         Exam CurrentExam = foundedlist[randomIndex];
         for (int i = 0; i < CurrentExam.Questions.Count; i++)
             {
               Console.WriteLine(CurrentExam.Questions[i].Display());
                string answerofstudent = Console.ReadLine();
                if (CurrentExam.Questions[i].Check(answerofstudent.ToLower()))
                 { founded.Grades += CurrentExam.Questions[i].Mark; }
                 }
   if (founded.State_of_exam == "not enter exam yet!")
 {founded.State_of_exam = $"In {CurrentExam.Subject} exam ,your result is {founded.Grades} from {CurrentExam.Totalgrade}"; }
  else 
  {founded.State_of_exam += $",In {CurrentExam.Subject} exam ,your result is {founded.Grades} from {CurrentExam.Totalgrade}"; }
 Console.WriteLine($"----your result is {founded.Grades} from {CurrentExam.Totalgrade}");
                        founded.Grades = 0;
                    }
                  
                }

                else { Console.WriteLine("---you are not in our system "); }
            }
            catch (FormatException e)
                { Console.WriteLine("---not valid answer"); }
        }


    }

    }
