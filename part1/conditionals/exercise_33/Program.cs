using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine ("Give the first string:");
      string input_string_one = Console.ReadLine();

      Console.WriteLine ("Give the second string:");
      string input_string_two = Console.ReadLine();

      if (input_string_one == input_string_two)
      {
        Console.WriteLine ("Echo!");
      }
      else
      {
        Console.WriteLine ("Nope!");
      }

    }
  }
}
