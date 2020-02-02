using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
     public static int Smallest(int num_1, int num_2)
     {
       if (num_1 < num_2)
       {
         return num_1;
       }
       else
       {
         return num_2;
       }
     }

  }
}
