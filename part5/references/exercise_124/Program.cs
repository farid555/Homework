using System;

namespace exercise_124
{ 
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
    ErrorClass syntax = new ErrorClass("Syntax", 10);
    Console.WriteLine(syntax);
    ErrorClass wrong = syntax;
    wrong.MoreWrong();
    Console.WriteLine(wrong);
    wrong = null;
    Console.WriteLine(wrong);
    wrong.MoreWrong();
      
    }
  }
}
