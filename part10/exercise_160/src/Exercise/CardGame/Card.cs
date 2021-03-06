namespace Exercise
{
  using System;
  public class Card : IComparable<Card>
  {
    public int value { get; }
    public Suit suit { get; }

    public Card(int value, Suit suit)
    {
      this.value = value;
      this.suit = suit;
    }

    public override string ToString()
    {
      if (this.value == 11)
      {
        return this.suit + " j";
      }
      if(this.value == 12)
      {
        return this.suit + " Q";
      }
      if (this.value == 14)
      {
        return this.suit + " A";
      }
      return this.suit + " " + this.value;
    }

    public int CompareTo(Card another)
    {
      if (this.value == another.value)
      {
        return this.suit.CompareTo(another.suit);
      }
      return this.value.CompareTo(another.value); 
    }
  }
}