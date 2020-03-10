using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
    List<TelevisionProgram> list = new List<TelevisionProgram>();

    while(true)
    {
      // name for the show
      Console.Write("Name: ");
      String name = Console.ReadLine();
      //break on empty
      if(name == "")
      {
        break;
      } 
      //how long is the show
      Console.Write("Duration: ");
      int duration = Convert.ToInt32(Console.ReadLine());
      

      //add the nmae of show
      list.Add(new TelevisionProgram(name, duration));
    }
    // for empty line
    Console.WriteLine();
    Console.Write("Program's maximum duration? ");
    int duration_max = Convert.ToInt32(Console.ReadLine());

    foreach(TelevisionProgram program in list)
    {
      if (duration_max >= program.duration){
        Console.WriteLine(program.name + ", " +program.duration + " minutes");

      }
    }

    }
  }
}




