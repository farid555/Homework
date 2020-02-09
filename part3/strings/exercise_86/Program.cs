using System;
using System.Collections.Generic;

namespace exercise_86 {
  class Program {
    public static void Main (string[] args) {
      while (true) {
        string asked = Console.ReadLine ();
        // break if empty
        if (asked == "") {
          break;
        } // split at white space
        //creat array
        string[] parts = asked.Split (" ");
        foreach (string line in parts) {
          Console.WriteLine (line);
        }
      }

    }
  }
}