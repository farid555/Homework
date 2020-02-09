using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write ("Give a string: ");

      string user_input = Console.ReadLine();

      if (user_input == "true"){
        Console.WriteLine("You got it right!");
      }
      else
      {
        Console.WriteLine ("Try again!");
      }


    }
  }
}

