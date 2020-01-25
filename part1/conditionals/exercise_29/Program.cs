using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine ("Give the first number!");
      string first_input = Console.ReadLine();

      Console.WriteLine ("Give the second number!");
      string secnond_input = Console.ReadLine();

      int first_value = Convert.ToInt32(first_input);
      int second_value = Convert.ToInt32(secnond_input);

      if (first_value == second_value)
       {
          Console.WriteLine ("They are equal!");
       }
       else if(first_value > second_value)
       {
         Console.WriteLine ("The larger number is " + first_value + "!" );
       }
       else
       {
         Console.WriteLine ("The larger number is " + second_value + "!" );
       }

    }
  }
}
