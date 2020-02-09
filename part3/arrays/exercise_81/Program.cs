using System;
using System.Collections.Generic;

namespace exercise_81 {
  class Program {
    public static void Main (string[] args) {
      int[] array = { 5, 1, 3, 4, 2 };
      PrintNeatly (array);
      // You can test your method here

    }

    public static void PrintNeatly (int[] array) {
          // look in to the array
      for (int i = 0; i < array.Length; i++) {
          //print the array
        if (i < array.Length - 1) {

          Console.Write (array[i] + ", ");

        } else {
          // only print the number
          Console.Write (array[i] + "\n");
        }

      }

    }
  }
}