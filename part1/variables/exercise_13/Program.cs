using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number !");
      string user_Input = Console.ReadLine();
      double double_Value = Convert.ToDouble(user_Input);
      Console.WriteLine("You gave: " + double_Value);

    }
  }
}
