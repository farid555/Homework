using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Person ada = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
      Person esko = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");
      Console.WriteLine(ada);
      Console.WriteLine(esko);

      Console.WriteLine();

     /* Student ollie = new Student("Ollie","6381 Hollywood Blvd. Los Angeles 90028 credits:");
      Console.WriteLine(ollie);
      ollie.Study();
      Console.WriteLine(ollie);

      Console.WriteLine();

      Teacher adaPoor = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200);
      Teacher eskoRich = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400);
      Console.WriteLine(adaPoor);
      Console.WriteLine(eskoRich);
      */
    }
  }
}