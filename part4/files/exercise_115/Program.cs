using System;

namespace exercise_115 {
  class Program {
    public static void Main (string[] args) {
         


      while (true) {
        string user_input = Console.ReadLine();
        if (user_input == "end") {
          break;
        }
         int number = Convert.ToInt32(user_input);
         Console.WriteLine(number*number*number); 

      }
    }
  }
}