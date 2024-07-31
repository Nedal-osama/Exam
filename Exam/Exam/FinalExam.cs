using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Exam
{
    public class FinalExam : Exam
    {
        public Question[] Questions { get; set; }

        public FinalExam(DateTime timeOfExam, int numberOfQuestions, Subject subject, Question[] questions)
            : base(timeOfExam, numberOfQuestions, subject)
        {
            Questions = questions;
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            foreach (var question in Questions)
            {
                Console.WriteLine(question.ToString());
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine(answer.ToString());
                }
            }
        }
    }

}
