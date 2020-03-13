namespace exercise_124
{
  public class ErrorClass
  {
    private string name;
    private int value;

    public ErrorClass(string name, int value)
    {
      this.name = name;
      this.value = value;
    }

    public void MoreWrong()
    {
      this.MoreWrong(1);
    }
    public void MoreWrong(int numbers)
    {
      this.value += numbers;
    }
    public override string ToString()
    {
      return "ERRoR! " + this.name + " error has appearad " + this.value + " times!";
    }
  }
}