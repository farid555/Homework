using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {


      // Write your code here:
     int neg_number = 0;

     while(true)
     {
          
      Console.WriteLine ("Give a number:");
      int user_number = Convert.ToInt32(Console.ReadLine());

      if(user_number == 0)
      {
        break;
      } 
      if (user_number < 0)
      {
        neg_number++;
      }
       
     }
       Console.WriteLine ("Total amount of negative numbers: " +  neg_number);

    }
  }
}
