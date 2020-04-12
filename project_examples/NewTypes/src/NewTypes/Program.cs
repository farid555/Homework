using System;
using Pets;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Dog doggie = new Dog();
      Cat cattie = new Cat();
      Birds birdie = new Birds();
      Console.WriteLine(doggie.TalkToOwner());
      Console.WriteLine(cattie.TalkToOwner());
      Console.WriteLine(birdie.TalkToOwner());
    }
  }
}