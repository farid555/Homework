using System;
using System.Collections.Generic;
namespace extra_05
{
  class Program
  {
    public static void Main(string[] args)
    {
       for(int i = 1; i < 6; i++)
       {
         Console.WriteLine(i);
       }
      
        
        Console.WriteLine("Give words, 'end' quits:");
        List<string> list = new List<string>(); 
        
       while(true)
       {
         string input = Console.ReadLine();
         if (input == "end")
         {
           break;
         }
         list.Add(input);
        
       }
       foreach (string word in list)
       {
           Console.WriteLine(word);
       }
    
    }
  }
}
