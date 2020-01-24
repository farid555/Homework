using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number !");
      string user_Input = Console.ReadLine();
      int int_Value = Convert.ToInt32(user_Input);
      Console.WriteLine("You gave: " + user_Input);

    }
  }
}
