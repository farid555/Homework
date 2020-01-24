using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string first_input = Console.ReadLine();

      Console.WriteLine("Give the second number!");
      string second_input = Console.ReadLine();

      Console.WriteLine("Give the third number!");
      string third_input = Console.ReadLine();

      int first_value = Convert.ToInt32(first_input);
      int second_value = Convert.ToInt32(second_input);
      int third_value = Convert.ToInt32(third_input);
      
      Console.WriteLine ("The sum is: " + (first_value + second_value + third_value ));
      

    }
  }
}
