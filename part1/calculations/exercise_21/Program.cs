using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {
              
      // Write your code here:
     Console.WriteLine ("Give the first number!");
     string input = Console.ReadLine();

     Console.WriteLine  ("Give the second number!");
     string input_two = Console.ReadLine();

     int value_one = Convert.ToInt32(input);
     int value_two = Convert.ToInt32(input_two);

     double average = (value_one + value_two) / 2.0;

     Console.WriteLine ("The average is " + average);


    }
  }
}
