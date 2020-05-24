namespace Exercise
{
  using System;
  public class Person
  {

    public string name { get; }
    public int age { get; }

    public Person(string name, int age)
    {
      if(name == null || name == "" || name.Length > 40)
      {
        throw new ArgumentException();
      }
      this.name = name;
      if (age < 0 || age > 120)
      {
        throw new ArgumentException();
      }
      this.age = age;
    }
  }
}