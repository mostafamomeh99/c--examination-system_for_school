using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Choose:Question
    {
       public List<string> Choices { get; set; } =new List<string>();
        public Choose(string body = "unknown", string answer = "unknown", int mark = 0) : base(body, answer, mark)
        { }
        public void Addchoices()
        {
            Console.WriteLine("enter first choices for question");
            string choices1 = Console.ReadLine().ToLower();
            Choices.Add(choices1);
            Console.WriteLine("enter second choices for question");
            string choices2 = Console.ReadLine().ToLower();
            Choices.Add(choices2);
            Console.WriteLine("enter third choices for question");
            string choices3 = Console.ReadLine().ToLower();
            Choices.Add(choices3);
            Console.WriteLine("enter four choices for question");
            string choices4 = Console.ReadLine().ToLower();
            Choices.Add(choices4);
        }
        public override string Display()
        {
            return $"{Body}?\na- {Choices[0]}\nb- {Choices[1]}\nc- {Choices[2]}\nd- {Choices[3]}";
        }

        public override Boolean Check(string answerfromstud)
        {
            if (Answer.ToLower() == answerfromstud)
            { return true; }
            else { return false; }
        }

    }
}
