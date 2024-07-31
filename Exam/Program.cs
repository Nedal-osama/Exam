using Exam.Exam;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a subject
            Subject subject = new Subject( 1, "Dark information");

            #region Question
            Question[] questions = new Question[]
               {
                  new TrueFalseQuestion("Is the Earth flat?", "Basic geography question", 1),
                  new MCQQuestion("What is the boiling point of water?", "Science question", 2,
                  new Answer[] { new Answer(1, "100°C"), new Answer(2, "0°C"), new Answer(3, "50°C") }),
                  new MCQQuestion("Who wrote 'Hamlet'?", "Literature question", 3,
                  new Answer[] { new Answer(1, "William Shakespeare"), new Answer(2, "Charles Dickens"), new Answer(3, "Jane Austen") })
       };
            #endregion


            #region right answer for each question
            questions[0].RightAnswer = questions[0].AnswerList[0];
            questions[1].RightAnswer = questions[1].AnswerList[0];
            questions[2].RightAnswer = questions[2].AnswerList[2];
            #endregion


            #region a final exam
            FinalExam finalExam = new FinalExam(DateTime.Now, 3, subject, questions);
            subject.CreateExam(finalExam);
            finalExam.ShowExam();
            #endregion


            #region practical exam
            PracticalExam practicalExam = new PracticalExam(DateTime.Now, 2, subject, new Question[] { questions[1], questions[2] });
            subject.CreateExam(practicalExam);
            practicalExam.ShowExam();
            #endregion
         
        }
    }
}
