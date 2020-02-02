using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine ("Give a number:");
      string user_input = Console.ReadLine();

      int user_value = Convert.ToInt32(user_input);
      if (user_value % 2 == 0)
      {
        Console.WriteLine ("It is even.");
      }
      else
      {
          Console.WriteLine ("It is odd.");
      }

    }
  }
}
