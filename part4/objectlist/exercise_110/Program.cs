using System;
using System.Collections.Generic;

namespace exercise_110 {
  class Program {
    public static void Main (string[] args) {
      // IMPLEMENT YOUR CODE IN HERE!
      List<Item> items = new List<Item> ();
      while (true) {
        // Console.Write ("Enter a name, empty will stop: ");
        Console.Write ("Name: ");
        string name = Console.ReadLine ();
        if (name == "") 
        {
          break;
        }
        // add name to the list
        items.Add (new Item (name));
      }
      Console.WriteLine ();
      foreach (Item name in items) {
        Console.WriteLine (name);
      }
   
    }
    }
  }
