using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {  

      int year = 1900;
      // Write your code here:
      Console.WriteLine ("Give your age:");
      string user_age = Console.ReadLine();

      int value = Convert.ToInt32(user_age);
      
      if (value <year)
      {
          Console.WriteLine ("You are old:" );
      }


      

    }
  }
}
