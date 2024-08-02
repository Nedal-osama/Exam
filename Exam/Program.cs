using Exam.Exam;
using System.Diagnostics;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a data static
            //  Subject subject = new Subject( 1, "Dark information");

            #region Question
            /*   Question[] questions = new Question[]
                  {
                     new TrueFalseQuestion("Is the Earth flat?", "Basic geography question", 1),
                     new MCQQuestion("What is the boiling point of water?", "Science question", 2,
                     new Answer[] { new Answer(1, "100°C"), new Answer(2, "0°C"), new Answer(3, "50°C") }),
                     new MCQQuestion("Who wrote 'Hamlet'?", "Literature question", 3,
                     new Answer[] { new Answer(1, "William Shakespeare"), new Answer(2, "Charles Dickens"), new Answer(3, "Jane Austen") })
          };*/
            #endregion


            #region right answer for each question
            /*    questions[0].RightAnswer = questions[0].AnswerList[0];
                questions[1].RightAnswer = questions[1].AnswerList[0];
                questions[2].RightAnswer = questions[2].AnswerList[2];*/
            #endregion


            #region a final exam
            /*  FinalExam finalExam = new FinalExam(DateTime.Now, 3, subject, questions);
              subject.CreateExam(finalExam);
              finalExam.ShowExam();*/
            #endregion


            #region practical exam
            /* PracticalExam practicalExam = new PracticalExam(DateTime.Now, 2, subject, new Question[] { questions[1], questions[2] });
             subject.CreateExam(practicalExam);
             practicalExam.ShowExam();*/
            #endregion*/





            //Create a data from user


                 Console.Write("Enter subject ID: ");
                 int subjectId = Convert.ToInt32(Console.ReadLine());
                  Console.Write("Enter subject name: ");
                  string subjectName = Console.ReadLine();
                  Subject subject = new Subject(subjectId, subjectName);

                  Console.Write("Enter number of questions: ");
                    int numQuestions = Convert.ToInt32(Console.ReadLine());
                   Question[] questions = new Question[numQuestions];

                    for (int i = 0; i < numQuestions; i++)
                            {
                                Console.Write($"Enter question {i + 1} type (1 for True/False, 2 for MCQ): ");
                                int questionType = Convert.ToInt32(Console.ReadLine());

                                if (questionType == 1)
                                {
                                    Console.Write($"Enter question {i + 1} text: ");
                                    string questionText = Console.ReadLine();

                                    Console.Write($"Enter question {i + 1} description: ");
                                    string questionDescription = Console.ReadLine();

                                    questions[i] = new TrueFalseQuestion(questionText, questionDescription, i + 1);
                                }
                                else if (questionType == 2)
                                {
                                    Console.Write($"Enter question {i + 1} text: ");
                                    string questionText = Console.ReadLine();

                                    Console.Write($"Enter question {i + 1} description: ");
                                    string questionDescription = Console.ReadLine();

                                    Console.Write($"Enter number of answers for question {i + 1}: ");
                                    int numAnswers = Convert.ToInt32(Console.ReadLine());

                                    Answer[] answers = new Answer[numAnswers];

                                    for (int j = 0; j < numAnswers; j++)
                                    {
                                        Console.Write($"Enter answer {j + 1} text for question {i + 1}: ");
                                        string answerText = Console.ReadLine();

                                        answers[j] = new Answer(j + 1, answerText);
                                    }

                                    questions[i] = new MCQQuestion(questionText, questionDescription, i + 1, answers);
                                }
                            }

                            Console.Write("Enter final exam duration: ");
                            int finalExamDuration = Convert.ToInt32(Console.ReadLine());

                            FinalExam finalExam = new FinalExam(DateTime.Now, finalExamDuration, subject, questions);
                            subject.CreateExam(finalExam);

                            Console.Write("Enter practical exam duration: ");
                            int practicalExamDuration = Convert.ToInt32(Console.ReadLine());

                            PracticalExam practicalExam = new PracticalExam(DateTime.Now, practicalExamDuration, subject, questions);
                            subject.CreateExam(practicalExam);

                            finalExam.ShowExam();
                            practicalExam.ShowExam();

         
        }
        }

    }
