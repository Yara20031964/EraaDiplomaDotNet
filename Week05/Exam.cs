using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    internal class Exam
    {
        // list of question that class doctor add on it the student use it from start exam 
        public List<Question> questions {  get; set; }

        public Exam()
        {
            questions = new List<Question>();
        }

        // Only Doctor has acess to this function 
        public void CreateExam()
        {

            Console.WriteLine("How many Question? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nSelect Question Type: 1) True / False  2) Choose One 3) MultiChoice ");

                Console.Write("Enter Type: ");
                int header = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the question: ");
                string body = Console.ReadLine();

                Console.Write("Enter the level: ");
                string level = Console.ReadLine();

                Console.Write("Enter the Mark: ");
                int mark = Convert.ToInt32(Console.ReadLine());

                if (header == 1) //True/False
                {
                    var q = new TrueORFalse(level, QType.TrueORFalse, body, mark);
                    q.Answers.Add(new Answer("True", false));
                    q.Answers.Add(new Answer("False", false));
                    Console.Write("Enter the correct option number 1.True 2.False: ");
                    int correctIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    q.Answers[correctIndex].IsCorrect = true;
                    questions.Add(q);
                }

                else if (header == 2) // Choose One
                {
                    var q = new ChooseOneQuestion(level, QType.ChooseOne, body, mark);

                    Console.Write("How many options? ");
                    int options = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < options; j++)
                    {
                        Console.Write($"Enter option {j + 1}: ");
                        string ans = Console.ReadLine();
                        //set all answer is false until doctor enter the correct one
                        q.Answers.Add(new Answer(ans, false));
                    }

                    Console.Write("Enter the correct option number: ");
                    int correctIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    q.Answers[correctIndex].IsCorrect = true;
                    questions.Add(q);
                }

                else if (header == 3) // MultiChoice
                {
                    var q = new MultiChoose(level, QType.MultipleChoice, body, mark);

                    Console.Write("How many options? ");
                    int options = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < options; j++)
                    {
                        Console.Write($"Enter option {j + 1}: ");
                        string ans = Console.ReadLine();
                        q.Answers.Add(new Answer(ans, false));
                    }

                    Console.Write("Enter the correct option numbers (e.g. 1 3): ");
                    string input = Console.ReadLine();
                    string[] correctParts = input.Split(' ');

                    foreach (string part in correctParts)
                    {
                        //we will subtract one bec. idex start with zero
                        int idx = Convert.ToInt32(part.Trim()) - 1;
                        q.Answers[idx].IsCorrect = true;
                    }
                    questions.Add(q);
                }




            }
        }

        //Student use this class
        public void StartExam()
        {
            Console.WriteLine("\n ------Exam Started -------\n");

            int totalMarks = 0;
            int totalObtained = 0;

            foreach (Question question in questions)
            {
                question.Print();
                Console.Write("Your Answer: ");
                string input = Console.ReadLine();

                totalMarks += question.QMark;

                //Check if the answer is correct
                if (question is TrueORFalse)
                {

                    if ((input == "1" && question.Answers[0].IsCorrect) ||
                        (input == "2" && question.Answers[1].IsCorrect))
                        totalObtained += question.QMark;

                }
                else if (question is ChooseOneQuestion)
                {
                    int idx = Convert.ToInt32(input) - 1;
                    if (question.Answers[idx].IsCorrect)
                        totalObtained += question.QMark;
                }
                else
                {
                    var TwoAnswer = input.Split(" ");
                    bool allCorrect = true;

                    foreach (var a in TwoAnswer)
                    {
                        // to remove any extra space 
                        int idx = Convert.ToInt32(a.Trim()) - 1;
                        if (!question.Answers[idx].IsCorrect)
                        {
                            allCorrect = false;
                            break;
                        }
                    }

        
                    if (allCorrect)
                        totalObtained += question.QMark;
                }
            }
            Console.WriteLine($"\nExam Finished! Your Score: {totalObtained}/{totalMarks}");
        }
    }
}
