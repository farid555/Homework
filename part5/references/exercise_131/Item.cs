namespace exercise_131
{
  public class Item
  {

    private string identifier;
    private string name;

    public Item(string identifier, string name)
    {
      this.identifier = identifier;
      this.name = name;
    }
    public override string ToString()
    {
      return this.identifier + ": " + this.name;
    }

    public override bool Equals(object compared)
    {

      //compare with Item.identifier
      if(this == compared)
      {
        return true;
      }

      // if the compared object is null or not of type item, the object are not equel
      if((compared == null) || !this.GetType().Equals(compared.GetType()))
      { 
        return false;
      }
      Item comparedItem = (Item)compared;
      //if the values of the object variables are the same, the objects are equel
      if (this.identifier == comparedItem.identifier)
      {
        return true;
      }
      //otherwise the objects are not equal
      return false;
      }
    }

  }

