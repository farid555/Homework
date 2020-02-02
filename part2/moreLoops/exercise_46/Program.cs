using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int user_input = Convert.ToInt32(Console.ReadLine());

      int start = user_input;
      int end = 100;

      int a = 0;
      
      for (a = user_input; a <= end; a++)
      {
        Console.WriteLine (a);
      }

    }
  }
}
