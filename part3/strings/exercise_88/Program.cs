using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {
      while(true)
      {
        string asked = Console.ReadLine();
        if (asked == ""){

          break;
        }
        //split at white space
        // creat array
        string[] parts = asked.Split(" ");
        Console.WriteLine(parts[0]);
      }

    }
  }
}



