using System;
using System.Collections;
using System.Data;

namespace extra_06 {
  class Program {
    public static void Main (string[] args) {
      // Add your code here:

      int i = 0;
      Console.WriteLine("GIVE ME TWO INT INPUT:");
      int input_1 = Convert.ToInt32(Console.ReadLine());
      int input_2 = Convert.ToInt32(Console.ReadLine());

      i = input_1 + input_2;
      
      if (i > 0 )
      {
         Console.WriteLine("The square root is:" + Math.Sqrt(i));
      }
      else
      {
        Console.WriteLine("printing 0");
      }
     
    }
  }

}