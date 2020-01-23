using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
         
         int formula = 60 * 60 * 24;
         Console.WriteLine("How many days?");
         string user_input = Console.ReadLine();

        int value = Convert.ToInt32(user_input);
        Console.WriteLine(formula * value);



    }
  }
}
