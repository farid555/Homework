using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
       
      // Write your code here:
       int first_num = Convert.ToInt32(Console.ReadLine());
       int second_num = Convert.ToInt32(Console.ReadLine());
       
       int total_num = (first_num + second_num);
       
       double squareRoot = Math.Sqrt(total_num);
       Console.WriteLine(squareRoot);

    
    }
  }
}
