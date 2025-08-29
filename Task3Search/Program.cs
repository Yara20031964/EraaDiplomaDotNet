namespace Task3Search
{
    internal class Program
    {
        static string CheckVowel (string s)
        {
            s.ToLower ();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'i' || s[i] == 'o' || s[i] == 'a' || s[i] == 'e' || s[i] == 'u')
                {
                    throw new Exception("String that you entered contain vowel");
                }
            }
            return "safe";
        }
        static void Main(string[] args)
        {
            //Task 1
            //try
            //{
            //    List<int> list = new List<int>();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine($"Please Enter number {i +1}");
            //        int num = Convert.ToInt32( Console.ReadLine() );
            //        if (list.Contains(num)){
            //            throw new Exception("No duplicate number");
            //        }
            //        list.Add(num);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Erorr: {ex.Message}");
            //}

            //=========================================================================================
            //Task 2
            try
            {
                Console.WriteLine("Please enter string that you need to check it ");
                string s = Console.ReadLine();
                Console.WriteLine(CheckVowel(s));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erorr: {e.Message}");
            }

        }
    }
}
