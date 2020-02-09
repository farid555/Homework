using System;
using System.Collections.Generic;

namespace exercise_91 {
  class Program {
    public static void Main (string[] args) {
      int old = 0;
      string name = "";

      while (true) {
        string input = Console.ReadLine();
        if (input == "") {
          break;
        }
        string[] parts = input.Split (",");
        if (old < Convert.ToInt32(parts[1])) {

            old = Convert.ToInt32 (parts[1]);
            name = parts[0];
          }
        }
        Console.WriteLine ("Name of the oldest: " + name);
      }
    }
  }