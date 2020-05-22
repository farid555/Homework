using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      ProductWarehouse juice = new ProductWarehouse("Juice", 1000);
      juice.AddToWarehouse(1000);
      juice.TakeFromWarehouse(11);
      Console.WriteLine(juice.productName); // Juice
      Console.WriteLine(juice);
    }
  }
}
