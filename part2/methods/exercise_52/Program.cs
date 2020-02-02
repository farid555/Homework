using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
       PrintFromNumberToOne(6);
    }
       
       public static void PrintFromNumberToOne(int number)
    // Write your method here:
       {
         while(number > 0)
         {
           Console.WriteLine (number);
           number--;
         }

       }    
  }
}
