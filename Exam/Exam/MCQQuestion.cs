using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Exam
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answers)
            : base(header, body, mark)
        {
            AnswerList = answers;
        }

        public override object Clone()
        {
            return new MCQQuestion(Header, Body, Mark, AnswerList);
        }

        public override int CompareTo(Question other)
        {
            return Mark.CompareTo(other.Mark);
        }
    }
}
