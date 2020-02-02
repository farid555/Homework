using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int first_intger = Convert.ToInt32(Console.ReadLine());
      int second_intger = Convert.ToInt32(Console.ReadLine());

      if(first_intger > second_intger)
      {
        Console.WriteLine (first_intger + " is greater than " + second_intger +".");
      }
      else if (first_intger < second_intger)
      {
        Console.WriteLine (first_intger + " is less than " + second_intger +".");
      }
      else
      {
        Console.WriteLine (first_intger + " is equal to " + second_intger+ ".");
      } 
    }
  }
}
