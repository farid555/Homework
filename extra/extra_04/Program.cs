using System;

namespace extra_04
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      int input_percent = Convert.ToInt32(Console.ReadLine());

     
          if (input_percent < 1)
            {
              Console.WriteLine("Impossible ");
            }
         else if (input_percent < 50)
            {
              Console.WriteLine("Grade: Fail");
            }
        else if (input_percent < 60)
            {
              Console.WriteLine("Grade: 1");
            }
        else if (input_percent < 70)
            {
              Console.WriteLine("Grade: 2");
            }
        else if (input_percent < 80)
            {
              Console.WriteLine("Grade: 3");
            }
        else if (input_percent < 90)
            {
              Console.WriteLine("Grade: 4");
            }
        else if (input_percent < 101)
            {
              Console.WriteLine("Grade: 5");
            }
            else
                   {
                    Console.WriteLine("Outstanding!");
                   }
      
      }
  }
}
