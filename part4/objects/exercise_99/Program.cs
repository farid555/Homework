﻿using System;

namespace exercise_99
{
  class Program
  {
    public static void Main(string[] args)
    {

      DecreasingCounter counter = new DecreasingCounter(10);
      counter.PrintValue();

      //counter.Reset();
      counter.Decrement();
      counter.PrintValue();
      counter.Decrement();
      counter.PrintValue();
      counter.Decrement();
      counter.PrintValue();
      counter.Decrement();
      counter.PrintValue();
     
    }
  }
}



