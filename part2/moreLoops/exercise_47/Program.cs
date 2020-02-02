using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine ("Where to?");
      int first_input = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine ("Where from?");
      int second_input = Convert.ToInt32(Console.ReadLine());
      int start = second_input;

      while(start <= first_input)
      {
        Console.WriteLine(start);
        start++;

      }


      
    }
  }
}
