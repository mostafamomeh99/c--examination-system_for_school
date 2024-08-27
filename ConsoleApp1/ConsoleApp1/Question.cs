using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Question
    {
        public Question(string body="unknown", string answer = "unknown", int mark=0)
        {
            Body = body;
            Mark = mark;
            Answer = answer;
        }

        public string Body { get; set; }
        public string Answer { get; set; }
        public int Mark { get; set; }

        public abstract string Display();
        public abstract Boolean Check(string x);
    }
}
