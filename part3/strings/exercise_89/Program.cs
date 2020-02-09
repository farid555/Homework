using System;
using System.Collections.Generic;

namespace exercise_89 {
  class Program {
    public static void Main (string[] args) {

      while (true) {

        string asked = Console.ReadLine ();
        // break if empty
        if (asked == "") {
          break;
        }
        // creat array 
        // split at white space
       string[] parts = asked.Split(" ");
       Console.WriteLine(parts [parts.Length -1]);
        //Console.WriteLine(parts[0]);
        // get last part of string from array
        // array starts from 0, so -1 is needed 
        //int last = parts.Lenght -1;
        // print last part of string
        //Console.WriteLine (parts[last]);
      }

    }
  }
}