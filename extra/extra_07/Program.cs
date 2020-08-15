using System;
using System.Collections.Generic;

namespace extra_07
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
     int counter = 0;
     
     Console.WriteLine("Give integers, 'end' quits:");

     while(true)
     {
       string input = Console.ReadLine();
       if(input == "end")
       {
         break;
       }
       int number = Convert.ToInt32(input);
       counter += number;
     }
       Console.WriteLine("sum: " + counter);

     


    }
  }
}
