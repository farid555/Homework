using System;
using System.IO;

namespace exercise_119 {
  class Program {
    public static void Main(string[] args) {
      //creat new timer
      Timer timer = new Timer ();
      //loop until you cancel the loop
      //you can cancel by Ctrl+ C
      while (true) {
        Console.WriteLine (timer);
        timer.Advance ();
        // Some error proving, we'll talk about this later.
        // Known as try-catch.
        try {
          // Wait 100th of a second. 
          // Sleep(1000) waits one second, if you want to test at slower pace.
          System.Threading.Thread.Sleep (100);

        }
        // Other half of try-catch pair. 
        catch (Exception e) {
          Console.WriteLine ("Error happened: +" + e);
        }
      }
    }
  }
}