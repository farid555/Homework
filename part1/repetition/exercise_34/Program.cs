using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
        while(true)
        {
          Console.WriteLine ("Do you want to continue?");
          string user_input = Console.ReadLine();
           
          if (user_input == "no")
          {
            break;           
          }

        }
    }
  }
}
