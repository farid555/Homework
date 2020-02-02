using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      int a = 0 ;

      // Call your method here:
      Console.WriteLine ("How many times?");
      int number_of_times = Convert.ToInt32(Console.ReadLine());

      for(a = 0; a < number_of_times; a++ )
      {
       PrintPhrase();
      }
 
    }

    // Write your method here:
    public static void PrintPhrase()
    {
     Console.WriteLine ("In a hole in the ground there lived a method");
    }
  }
}
