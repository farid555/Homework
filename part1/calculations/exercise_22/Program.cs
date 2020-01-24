using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
       Console.WriteLine ("Give the first number!");
       string first_input = Console.ReadLine();

       Console.WriteLine ("Give the second number!");
       string second_input = Console.ReadLine();

       Console.WriteLine ("Give the third number!");
       string third_input = Console.ReadLine();

       int value_one = Convert.ToInt32(first_input);
       int value_two = Convert.ToInt32(second_input);
       int value_three = Convert.ToInt32(third_input);

       double average = (value_one + value_two + value_three) / 3.0;

       Console.WriteLine ("The average is :" + average);




    }
  }
}
