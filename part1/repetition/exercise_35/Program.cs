using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
     while(true)
     {
        Console.WriteLine ("Give a number:");
        string user_input = Console.ReadLine();
        
        int value = Convert.ToInt32(user_input);

        if(value == 42)
        {
          break;
        }

     }


    }
  }
}
