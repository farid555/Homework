using System;

namespace extra_01
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:test 
      
      Console.WriteLine("What do you want to print???");
      string input = Console.ReadLine();
         
      Console.WriteLine("How many times you want to print?");
      int num_of_times = Convert.ToInt32(Console.ReadLine());
      int num = 0;

      while(num_of_times> num)
      {
        Console.WriteLine(input);
        num++;
      }
      
    }
  }
}
