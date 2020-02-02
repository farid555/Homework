using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int user_input = Convert.ToInt32(Console.ReadLine());
      
      if(user_input < 0)
      {
       Console.WriteLine (user_input * -1);
      } 
      else
      {
       Console.WriteLine (user_input);
      }
    }
  }
}
