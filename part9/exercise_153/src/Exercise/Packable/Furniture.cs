namespace Exercise
{
  public class Furniture : IPackable
  { 
    public string type {get; set;}
    public string color {get; set;}
    public int weight {get; set;}
    public Furniture(string s, string s2, int i)
    {
      this.type = type;
      this.color = color;
      this.weight = weight;

    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.color + " " + this.type + " - weight " + this.weight + " kg";
    }
  }
}