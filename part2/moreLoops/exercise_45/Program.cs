using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int user_input = Convert.ToInt32(Console.ReadLine());
       
       int user_number = 0; 
      while(user_number <= user_input)
      {
        Console.WriteLine (user_number);
        user_number++;

      }
     



    }
  }
}
