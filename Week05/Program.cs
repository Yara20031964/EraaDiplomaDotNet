using System;
//Note: i use var in some case like auto in c++ to tell compiler you will know the data type after assigned the value :)
namespace Week05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam exam = null;


            while (true)
            {
                Console.WriteLine("\n=== Welcome to Exam System ===");
                Console.WriteLine("1) Doctor");
                Console.WriteLine("2) Student");
                Console.WriteLine("3) Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1") // Doctor mode
                {
                    Console.WriteLine("\n=== Doctor Adding Questions ===");
                    //dctor create exam
                    exam = new Exam();
                    exam.CreateExam();
                    Console.WriteLine("Exam created successfully!");
                }
                else if (choice == "2") // Student mode
                {
                    if (exam == null)
                    {
                        Console.WriteLine(" No exam is available yet. Please wait for the doctor to create one.");
                    }
                    else
                    {
                        Console.WriteLine("\n=== Student Taking Exam ===");
                        exam.StartExam();
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting system... Bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again!");
                }
            }
        }
    }
}
