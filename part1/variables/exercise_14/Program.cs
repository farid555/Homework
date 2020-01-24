using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      // Write your code here:
      string user_Input = Console.ReadLine();
      bool boolean_value = System.Convert.ToBoolean(user_Input);
      Console.WriteLine(boolean_value);

    }
  }
}
