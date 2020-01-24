using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
     
      int year = 1984; 

      Console.WriteLine ("Give a number!");
      string user_input = Console.ReadLine();

      int input_value = Convert.ToInt32(user_input);

      if(input_value == year)
          {
              Console.WriteLine ("Orwell");
          }

          else

          {
              Console.WriteLine(user_input);
          }
    }
  }
}
