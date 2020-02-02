using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int num_1, int num_2, int num_3)
    {
        int answer = 0;

       if (num_1 > num_2 && num_1 > num_3)
       {
         answer = num_1;
       }
       else if (num_2 > num_1 && num_2 > num_3)
       {
         answer = num_2;
       }
       else 
       {
         answer = num_3;
       }

       return answer;
        
         }

  }
}
