using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int old = 0;
      //read from user
      while (true)
      {
        string input = Console.ReadLine ();
        //break if empth
        if (input == "")

        {
          break;
        }
        // split string into parts{0} and parts[1]
        // split strings into name and age
          string[] parts = input.Split(",");
        // check if age is greater than oldest
        if (Convert.ToInt32(parts[1]) > old){
          // if true oldest is now parts[1] value
          old = Convert.ToInt32(parts[1]);
        }
      }
           // print the old
           Console.WriteLine ("Age of the oldest: " + old);
    }
  }
}



