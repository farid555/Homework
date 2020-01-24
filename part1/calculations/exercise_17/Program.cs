using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine ("Give the first number!");
      string first_Input = Console.ReadLine();

      Console.WriteLine ("Give the second number!");
      string second_Input = Console.ReadLine();

      int first_value = Convert.ToInt32(first_Input);
      int second_value = Convert.ToInt16(second_Input);

      Console.WriteLine("The sum is: " + (first_value + second_value)); 


    }
  }
}
