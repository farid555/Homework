using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {  List<string> strings = new List<string> ();
      // You can try your method here if you want
      strings.Add ("First");
      strings.Add ("Second");
      strings.Add ("Third");
                      
       //**remember,this how we print all the items in a list               
      strings.ForEach (Console.WriteLine);

      RemoveLast (strings);
      RemoveLast (strings);

      strings.ForEach (Console.WriteLine);
    }    //method
       public static void RemoveLast (List<string> strings)
       {
         // find the last string value
         int last_value = strings.Count -1;
         //and remove it
         strings.RemoveAt (last_value);
       }
  }
}


