using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {    
             //start count
            int count = 0;    
           
            while (true)
            {
                string user_input = Console.ReadLine();
             if (user_input == "end")
             {
                 break;
             }
                count++;
            }
             //print number of lines
            Console.WriteLine(count);
             

        }
    }
}
