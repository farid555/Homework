using System;
using System.Collections.Generic;

namespace exercise_76 {
  class Program {
    public static void Main (string[] args) {
      List<int> num_bers = new List<int> ();
      num_bers.Add (2);
      num_bers.Add (6);
      num_bers.Add (-1);

      Console.WriteLine (Sum (num_bers));

      num_bers.Add (5);
      num_bers.Add (1);

      Console.WriteLine (Sum (num_bers));
    } // method

    public static int Sum (List<int> num_bers) {
      // start from zero
      int sum = 0;

      for (int i = 0; i < num_bers.Count; i++) {
        int number = num_bers[i];
        sum = sum + number;

      } //it shows the totals
      return (sum);
    }
  }
}