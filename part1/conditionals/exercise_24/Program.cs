using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int speed = 120;
      Console.WriteLine ("Your Speed: ");
      string input_speed = Console.ReadLine();

      int input_value = Convert.ToInt32(input_speed);

      

      if( input_value> speed)
      {
          Console.WriteLine("speeding! \n");
      }
      
      
    }
  }
}
