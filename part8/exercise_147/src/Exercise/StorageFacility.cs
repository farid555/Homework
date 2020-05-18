using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {
    private Dictionary<string, List<string>> contents;

    public StorageFacility()
    {
      this.contents = new Dictionary<string, List<string>>();
    }
    public void Add(string unit, string item)
    {
        if (!this.contents.ContainsKey(unit))
        {
          this.contents.Add(unit, new List<string>());
        }
        List<string> items = this.contents[unit];
        items.Add(item);
    }

    public List<string> Contents(string storageUnit)
    {
      if (!this.contents.ContainsKey(storageUnit))
      {
        this.contents.Add(storageUnit, new List<string>());
      }
      return this.contents[storageUnit];
    }

    public void Remove(string storageUnit, string item)
    {
       if (this.contents.ContainsKey(storageUnit))
       {
         if(this.contents[storageUnit].Contains(item))
         {
           this.contents[storageUnit].Remove(item);
         }
       }
    }

    public List<string> StorageUnits()
    {
      List<string> storageUnits = new List<string>();
      foreach (KeyValuePair<string, List<string>> storageUnit in this.contents)
      {
          if (storageUnit.Value.Count != 0)
          {
            storageUnits.Add(storageUnit.Key);
          }
      }
      return storageUnits;
    }
  }
}