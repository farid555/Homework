using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine ("How old are you?");
      string user_old = Console.ReadLine();

      int value = Convert.ToInt32(user_old);
         
      if(value >= 18)
      {
        Console.WriteLine ("You are an adult!");
      }
      else
      {
        Console.WriteLine ("You are under age!");
      }

    }
  }
}
