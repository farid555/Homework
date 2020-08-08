using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      // ask the user input integers
     
     Console.WriteLine("Give three number:");
     int num_one = Convert.ToInt32(Console.ReadLine());
     int num_two = Convert.ToInt32(Console.ReadLine());
     int num_three = Convert.ToInt32(Console.ReadLine());
     
     if (num_one > num_two)
     {
       Console.WriteLine("Largest: " + num_one);
     }
     else if (num_two > num_three)
     {
       Console.WriteLine("Largest: " + num_two);
     }
     else
     {
       Console.WriteLine("Largest: " + num_three);
     }
    }
  }
}
