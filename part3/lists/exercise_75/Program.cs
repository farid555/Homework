﻿using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
      numbers.Add (2);
      numbers.Add (6);
      numbers.Add (-1);
      numbers.Add (5);
      numbers.Add (1);

      // Example method calls for testing your method.
      // List<int> numbers = new List<int>();
      // numbers.Add(5);

      Console.WriteLine("The numbers in the range [0, 5]");
      PrintNumbersInRange(numbers, 0, 5);

      Console.WriteLine("The numbers in the range [3, 10]");
      PrintNumbersInRange(numbers, 3, 10);
    }
        //method
      public static void PrintNumbersInRange (List<int> numbers, int LowerLimit, int upperLimit)
      {
        for (int i = 0; i < numbers.Count; i++)
        {  
          int number = numbers[i];
          // check the numbers...
          if ((number >= LowerLimit) &&( number <= upperLimit))
          { //if both above are true, print the number
            Console.WriteLine(number);
          }
        }
      {
          
      }
    }
  }
}

