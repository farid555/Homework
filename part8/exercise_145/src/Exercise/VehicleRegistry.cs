using System;
using System.Collections.Generic;

namespace Exercise
{
  public class VehicleRegistry
  {
    private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
    public bool Add(LicensePlate licensePlate, string owner)
    {
       if (owners.ContainsKey(licensePlate))
       { 
         
         return false;
       }
       else
       {
          this.owners.Add(licensePlate, owner); 
           return true;
       }     
    }
    
    public string Get(LicensePlate licensePlate)
    {

      if (owners.ContainsKey(licensePlate))
      {
        return owners[licensePlate];
      }
      else
      {
        return "No such license found in registry!";
      } 
    }

    public bool Remove(LicensePlate licensePlate)
    {
      if (owners.ContainsKey(licensePlate))
      {
         return owners.Remove(licensePlate);
         
      }
      else
      {
        return false;
      }
    }
    public void PrintLicensePlates()
    {
      foreach (KeyValuePair<LicensePlate, string> kvp in owners)
      {
          System.Console.WriteLine(kvp.Key);
      }
    }
           //in the printowners methos, we can creat a list used for remembering the owners that were a;lready printed. if an owner is not on the their name is printed and thet are added to the list--if an owner is one the list their name isn't printed
    public void PrintOwners()
    {
        List<string> ownersList = new List<string>();

        foreach (KeyValuePair<LicensePlate, string> kvp in owners)
        {
        
           if (!ownersList.Contains(kvp.Value))
              ownersList.Add(kvp.Value);
        }

        foreach (string ownersName in ownersList)
        {
           System.Console.WriteLine(ownersName); 
        }
    }
  }
}
