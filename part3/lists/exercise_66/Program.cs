using System;
using System.Collections.Generic;

namespace exercise_66
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
            int values = list.Count;
            Console.WriteLine (list[values-1]);
    }
  }
}
