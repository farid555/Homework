using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string user_String = Console.ReadLine();

      Console.WriteLine("Given an integer:");
      string user_input = Console.ReadLine();
      int int_value = Convert.ToInt32(user_input);

      Console.WriteLine("Give a double:");
      string user_input_double = Console.ReadLine();
      double double_value = Convert.ToDouble(user_input_double);

      Console.WriteLine("Give a boolean:");
      string boolean_input = Console.ReadLine();
      bool boolean_value = System.Convert.ToBoolean(boolean_input);



      Console.WriteLine("Your string:" + user_String);
      Console.WriteLine("Your integer:"+ user_input);
      Console.WriteLine("Your double:" + user_input_double);  
      Console.WriteLine("Your boolean:" + boolean_input);
    }
  }
}
