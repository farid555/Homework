using System;
using System.Collections.Generic;

namespace exercise_85 {
  class Program {
    public static void Main (string[] args) {
  
         //user name
      Console.WriteLine("Enter username:");
      string user_id = Console.ReadLine ();
         //password
      Console.WriteLine("Enter password:");
      string user_pass = Console.ReadLine ();
               //compare user name and password
      if ((user_id == "alex" && user_pass == "sunshine") | (user_id == "emma" && user_pass == "haskell")) {
          // permission to access
        Console.WriteLine ("You have successfully logged in!");
      }
      else {
           // not allow
        Console.WriteLine ("Incorrect username or password!");
      }

    }
  }
}