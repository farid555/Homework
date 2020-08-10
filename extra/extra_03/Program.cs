using System;
using System.Collections.Generic;
//Ask the user for amount of integers,
//and then that many integers. Calculate and print their sum, multiplication and average.
namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    { 
       
      Console.WriteLine("How many numbers?");
      int howmany = Convert.ToInt32(Console.ReadLine());

      int num = 0;

      while(howmany > num)
      {
        num++;
      }

      Console.WriteLine("Give " + howmany + " numbers: ");
      int sum = 0;
      int multi = 1;
      //int valid = 0;
        
        for(int i =0; i < howmany; i++)
        {
          int number = Convert.ToInt32(Console.ReadLine());
          sum = sum + number; 
          multi = multi * number;
          //valid++;
          
        }
            double average = ((double) sum / howmany);

        Console.WriteLine("Their sum: " + sum);
        Console.WriteLine("Their total: " + multi);
        Console.WriteLine("Their average: " + average);
    }
  }
}
