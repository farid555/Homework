using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int count_num = 0;
      while(true)
      {
       Console.WriteLine ("Give a number:");
       int user_input = Convert.ToInt32(Console.ReadLine());
       
       if(user_input == 0)
       {
        break;
       }
       else 
       {
        count_num = count_num + user_input ;
       }
         }
         Console.WriteLine ("Total sum of numbers: " + count_num);
     }
  }
}
