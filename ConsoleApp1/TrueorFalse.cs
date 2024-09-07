using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TrueorFalse:Question
    {
        public TrueorFalse(string body = "unknown", string answer = "unknown", int mark = 0) : base(body, answer, mark)
        { }


        public override string Display()
        {
            return $"{Body}? / (T) true or (F) False /";
        }

        public override Boolean Check(string answerfromstud)
        {
            if(Answer.ToLower()==answerfromstud)
            {return true; }
            else { return false; }
        }

    }
}
