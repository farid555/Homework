using System;

namespace extra_11
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine ("Give a sentence:");
      string user_input = Console.ReadLine();

      string[] splits = user_input.Split(' ');
      
      foreach (var word in splits)
      {
          System.Console.WriteLine($"{word}");
      }
    }
  }
}
