using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      while(true)
      {
        Console.WriteLine("Give a number:");
        string user_input = Console.ReadLine();

        int input_value = Convert.ToInt32(user_input);

        if(input_value <0)
        {
          Console.WriteLine ("That is negative");
        }
        else if(input_value > 0)
        {
          Console.WriteLine (input_value * input_value);
        } 
        else if (input_value == 0)
        {
         break;
        }
      }

    }
  }
}
