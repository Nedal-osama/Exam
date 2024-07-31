using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Exam
{
    public abstract class Exam
    {
        public DateTime TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject Subject { get; set; }

        public Exam(DateTime timeOfExam, int numberOfQuestions, Subject subject)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            Subject = subject;
        }

        public abstract void ShowExam();
    }

}
