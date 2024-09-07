using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public Student(int id=0, string name="unknown", string state_of_exam="not enter exam yet!", double grades=0)
        {
            Id = id;
            Name = name;
            State_of_exam = state_of_exam;
            Grades = grades;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string State_of_exam{ get; set; }
        public double Grades { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, NAME : {Name}, state of  exams : {State_of_exam}";
        }
    }
}
