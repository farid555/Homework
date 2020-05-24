namespace Exercise
{
  using System;
  public class TemperatureSensor : Sensor
  {  
    private Random random;
    private bool isSensorOn;

    public TemperatureSensor()
    {
      this.random = new Random();
      this.isSensorOn = false;
    }

    public bool IsOn()
    { 
      if (true)
      {
        return this.isSensorOn;
      }
     
    }


    public void SetOn()
    {
      this.isSensorOn = true;
    }


    public void SetOff()
    {
      this.isSensorOn = false;
    }


    public int Read()
    {
      if (IsOn())
      {
        int Temperature = this.random.Next(61) - 30;
        return Temperature;
      }
      else
      {
          throw new InvalidOperationException();
      }
    }
  }
}