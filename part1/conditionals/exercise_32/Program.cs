using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
            // Write your code here:
    Console.WriteLine("Speak, friend, and enter!");
    
    string input_text = Console.ReadLine();
    
    if (input_text == "Mellon")
    {
      Console.WriteLine ("Welcome, friend!");
    }
    else
    {
      Console.WriteLine ("They've got a cave troll!");
    }

    }
  }
}
