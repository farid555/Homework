using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
    PrintUntilNumber(3);

    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
    {
      int a = 1;
      while ( a <= number)
      {
        Console.WriteLine (a);
        a++;
      }
    }
  }
}
