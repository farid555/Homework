namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class ChangeHistory
  {
    private List<int> history;

    public ChangeHistory()
    {
       this.history = new List<int>();
    }

    public void Add(int status)
    {
        this.history.Add(status);
    }

    public void Clear()
    {
        this.history.Clear();
    }

    public int MaxValue()
    {
      if(this.history.Count == 0)
      {
        return 0;
      }
      
      int largestValue = 0;
      foreach (var item in this.history)
      {
          if (item > largestValue)
          {
            largestValue = item;
          }
      }
       return largestValue; 
    }

    public int MinValue()
    {
      if(this.history.Count == 0)
      {
      return 0;
      }
      int smallestValue = MaxValue();
      foreach (var item in this.history)
      {
          if(item < smallestValue)
          {
            smallestValue = item;
          }
      }
      return smallestValue;
    }

    public int LastValue()
    {
      int lastValue = 0;
      foreach (var item in history)
      {
        lastValue = item;
      }
      return lastValue;
    }
    public override string ToString()
    {
      return "Current: " + LastValue() +" Min: "+ MinValue() +" Max: "+ MaxValue();
    }
  } 
}
