using System;

namespace Week3Part1
{
    internal class Program
    {
        // Print method
        static void Print(List<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine(" ------ Output -------------------------------------------");
            Console.Write(" [ ");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine("]                                            ");
            Console.WriteLine(" ---------------------------------------------------------");
            Console.WriteLine();
        }

        //Add number method 
        static void Add(List<int> nums, int n) {
            nums.Add(n);
            Console.WriteLine(" ------ Output --------------------------------------------");
            Console.WriteLine($" {n} added                                         ");
            Console.WriteLine(" ----------------------------------------------------------");
            Console.WriteLine();
        }

        //Calc mean method  
        static void DisplayMean(List<int> nums)
        {
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(" ------ Output --------------------------------------------");
            Console.WriteLine($" Mean: {sum / nums.Count}                                   ");
            Console.WriteLine(" ----------------------------------------------------------");
            Console.WriteLine();
        }

        //Display the smallest number method 
        static void GetSmallest(List<int> nums)
        {
            Console.WriteLine();
            int min = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine(" ------ Output --------------------------------------------");
            Console.WriteLine($" The smallest number is {min}                             ");
            Console.WriteLine(" ----------------------------------------------------------");
            Console.WriteLine();
        }

        //Display Largest number method
        static void GetLargest(List<int> nums)
        {
            Console.WriteLine();
            int max = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine(" ------ Output --------------------------------------------");
            Console.WriteLine($" The Largest number is {max}                             ");
            Console.WriteLine(" ----------------------------------------------------------");
            Console.WriteLine();
        }

        //Find a number method
        static void FindNum(List<int> nums, int num)
        {
            int index = -1;
            Console.WriteLine();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == num)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" ------ Output --------------------------------------------");
                Console.WriteLine(" Needed number Not found in the list                           ");
                Console.WriteLine(" ----------------------------------------------------------");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(" ------ Output --------------------------------------------");
                Console.WriteLine($" Needed number in index {index}                           ");
                Console.WriteLine(" ----------------------------------------------------------");
                Console.WriteLine();
            }
        }

        //Clear List Method
        static void Clear(List<int> nums)
        {
            nums.Clear();
            Console.WriteLine();
            Console.WriteLine(" ------ Output --------------------------------------------");
            Console.WriteLine($" List clear successed                                     ");
            Console.WriteLine(" ----------------------------------------------------------");
            Console.WriteLine();
        }

        //

        static void Main(string[] args)
        {
            // Intialize list of number befor while loop to avoid rest list every cycle:)
            List<int> nums = new List<int>();
            // While true to program to still loop untill quit
            while (true)
            // Design the border of menu
            {   // To change the color to green
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" ------ Main Menu----------------------------------------------");
                Console.WriteLine("| P - Print numbers                                            |");
                Console.WriteLine("| A - Add a number                                             |");
                Console.WriteLine("| M - Display a mean of the numbers                            |");
                Console.WriteLine("| S - Display the smallest number                              |");
                Console.WriteLine("| L - Display the largest number                               |");
                Console.WriteLine("| F - Find a number                                            |");
                Console.WriteLine("| C - Clear the whole list                                     |");
                Console.WriteLine("| Q - Quit                                                     |");
                Console.WriteLine(" --------------------------------------------------------------");
                Console.WriteLine();

                // Intialize character
                Console.ResetColor();
                Console.Write("Please choose one of this character P/A/M/S/L/F/C/Q: ");
                String choice = Console.ReadLine().ToUpper();

                // Check if list empty or not to avoid any operation to happen to empty list
                if (nums.Count == 0 && choice != "A" && choice != "Q")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" ------ Output -------------------------------------------");
                    Console.WriteLine(" [] The list is empty                                     ");
                    Console.WriteLine(" ---------------------------------------------------------");
                    //reste color to default
                    Console.ResetColor();
                }

                
                else if (choice == "P")
                {
                    Print(nums);
                }

                else if (choice == "A")
                {
                    Console.Write("Please enter the number that you want to add: ");
                    int Addednum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Add(nums,Addednum); 
                }

                else if (choice == "M")
                {
                    DisplayMean(nums);
                }

                else if (choice == "S")
                {
                    GetSmallest(nums);
                }

                else if (choice == "L")
                {
                    GetLargest(nums);
                }

                else if (choice == "F")
                {
                    Console.Write("Please enter the number that you want to find it: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    FindNum(nums,num);

                }

                else if (choice == "C")
                {
                    Clear(nums);
                }

                // Quit from the programe
                else if (choice == "Q")
                {
                    break;
                }

                //Invalid input
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" ------ Output --------------------------------------------");
                    Console.WriteLine(" Invalid input please try again                            ");
                    Console.WriteLine(" ----------------------------------------------------------");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
        }
    }
}




