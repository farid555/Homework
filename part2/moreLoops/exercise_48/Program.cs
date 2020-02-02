using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
       Console.WriteLine ("Give numbers:");
       int sum = 0;
       int num = 0;
       int even = 0;
       int odd = 0;
       

       while(true)
       {
        int user_input = Convert.ToInt32(Console.ReadLine());
       

       if (user_input == -1 )
       {
         break;
       }
        sum = sum + user_input;
        num++;

        if((user_input % 2) == 0)
        {
          even++;
        }
        else
        {
          odd++;
        }

       }
       
       Console.WriteLine ("Thx! Bye!");
       Console.WriteLine ("Sum: " + sum);
       Console.WriteLine ("Numbers: " + num);
       Console.WriteLine ("Average: " + (double)sum/num);
       Console.WriteLine ("Even: " + even);
       Console.WriteLine ("Odd: " + odd);
 
    }
  }
}
