using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine ("Give the first number!");
      string first_input = Console.ReadLine();

      Console.WriteLine ("Give the first number!");
      string second_input = Console.ReadLine();

      int first_value = Convert.ToInt32(first_input);
      int second_value = Convert.ToInt32(second_input);

      Console.WriteLine (first_value + " + " + second_value + " = " + (first_value + second_value));


    }
  }
}
