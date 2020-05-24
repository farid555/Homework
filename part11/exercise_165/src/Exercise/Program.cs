namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      SaveableDictionary dictionary = new SaveableDictionary("words.txt");
      bool wasSuccessful = dictionary.Load();

            Console.WriteLine(dictionary.Translate("apina"));
            Console.WriteLine(dictionary.Translate("monkey"));
            Console.WriteLine(dictionary.Translate("beer"));
            Console.WriteLine(dictionary.Translate("olut"));
            Console.WriteLine(dictionary.Translate("below"));
            Console.WriteLine(dictionary.Translate("alla oleva"));

            // Try adding, translating and removing a word, this should not affect the file
            dictionary.Add("poista", "remove");
            Console.WriteLine(dictionary.Translate("remove"));
            dictionary.Delete("remove");

            // Save the file
            dictionary.Save();
    }
  }
}
