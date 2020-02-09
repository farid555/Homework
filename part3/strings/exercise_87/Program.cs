using System;
using System.Collections.Generic;

namespace exercise_87 {
  class Program {
    public static void Main (string[] args) {
      while (true) {
        string asked = Console.ReadLine ();
        //its break if empty
        if (asked == "") {
          break;
        }
        //split at white space
        //creat array
        string[] parts = asked.Split (" ");
        foreach (string line in parts) {
          if (line.Contains ("av")) {
            Console.WriteLine (line);
          }
        }
      }
    }

  }

}