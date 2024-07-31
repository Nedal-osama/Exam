using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Exam
{
   public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion(string header, string body, int mark) 
        : base(header, body, mark)
    {
        AnswerList = new Answer[] { new Answer(1, "True"), new Answer(2, "False") };
    }

    public override object Clone()
    {
        return new TrueFalseQuestion(Header, Body, Mark);
    }

    public override int CompareTo(Question other)
    {
        return Mark.CompareTo(other.Mark);
    }
}
}

