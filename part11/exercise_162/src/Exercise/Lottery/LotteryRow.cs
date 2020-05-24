namespace Exercise
{
  using System;
  using System.Collections.Generic;

  public class LotteryRow
  {  
    private List<int> numbers;

    
    public LotteryRow()
    {
      this.RandomizeNumbers();
    }

    public List<int> Numbers()
    {
      return this.numbers;
    }

    public bool ContainsNumber(int number)
    {
      // Tests whether the number is already among the randomized numbers
      if (this.umbers.Contains(int number))
      {
        return true;
      }
      else
      {
        return false;
      }
      
    }

    public void RandomizeNumbers()
    {
      // initialize the list for numbers
      this.numbers = new List<int>();
      // Implement the randomization of the numbers by using the method ContainsNumber() here
      Random lotteryNumbers = new Randdom();
      for (int i = 0; i < 7; i++)
      {
        int number = lotteryNumbers.Next(1, 41);
        {
          if (!this.Contains ());
          numbers.Add(number);
        }
          
      }
      numbers.Sort();
    }

  }
}