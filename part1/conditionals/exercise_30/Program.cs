using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
    Console.WriteLine ("Give your percent [0 - 100]:");
    string input_value = Console.ReadLine();

    int user_score = Convert.ToInt32(input_value);

    if (user_score < 0)
    {
      Console.WriteLine ("Impossible");
    }
    else if (user_score <=49 )
    {
      Console.WriteLine ("Fail");
    }
    else if (user_score <=59)
    {
      Console.WriteLine ("Grade: 1");
    }
    else if (user_score <=69 )
    {
      Console.WriteLine ("Grade: 2");
    }
    else if (user_score <=79)
    {
      Console.WriteLine ("Grade: 3");
    }
    else if (user_score <=89)
    {
      Console.WriteLine ("Grade: 4");
    }
    else if (user_score <= 100 )
    {
      Console.WriteLine ("Grade: 5");
    }
    else if (user_score > 100 )
    {
      Console.WriteLine ("Outstanding!");
    }
    }
    
  }
}
