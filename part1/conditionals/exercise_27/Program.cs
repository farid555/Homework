using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string input_number = Console.ReadLine();

      int value = Convert.ToInt32(input_number);
      
      if (value> 0)
      {
        Console.WriteLine("It is positive.");
      }
      else
      {
        Console.WriteLine("It is not positive.");
      }
    }
  }
}
