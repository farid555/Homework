namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class TextInterface
  {
    // Create the userinterface here
    private List<Book> books;
    public TextInterface()
    {
      this.books = new List<Book>();
    }

    public void Start()
    {
      while (true)
      {
          Console.WriteLine("Input the name of the the book, empty stops:");
          string name = Console.ReadLine();
          if (name == "")
          {
            break;
          }
          Console.WriteLine("Input the age recommendation:");
          string ageRec = Console.ReadLine();
          if(ageRec == "")
          {
            break;
          }
          
          int age = Convert.ToInt32(ageRec);
          this.books.Add(new Book(name, age));
      }
      Console.WriteLine(books.Count + " books in total.");
      Console.WriteLine();
      Console.WriteLine("Books:");
      books.Sort();
      foreach (Book item in this.books)
      {
          Console.WriteLine(item);
      }
    }
  }
}