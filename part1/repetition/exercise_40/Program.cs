using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum_number = 0;
      int count_num = 0;

      while (true)
      {
        Console.WriteLine ("Give a number:");
        int user_input = Convert.ToInt32(Console.ReadLine());

        if (user_input == 0)
        {
          break;
        }
        else
        {
          count_num = count_num + user_input;
          sum_number = sum_number + 1;
        }
          
      }
          Console.WriteLine ("Total sum of numbers: " + sum_number);
          Console.WriteLine ("Total amount of numbers: " + count_num);
        
    }
  }
}
