namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;
  public class SaveableDictionary
  {
    private Dictionary<string, string> translateWords;
    private string file;
    string word { get; set;}
    string translation { get; set;}

    public SaveableDictionary()
    {
      this.translateWords = new Dictionary<string, string>();
    }

    public SaveableDictionary(string file) : this()
    {
      this.file =file;
    }

    public void Add(string word, string translation)
    {
      this.word = word;
      this.translation = translation;
      if (!this.translateWords.ContainsKey(word))
      {
        this.translateWords.Add(word, translation);
      }
    }

    public bool Load()
    {
      try {

        string[] lines = File.ReadAllLines(this.file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            this.translateWords.Add(parts[0], parts[1]);
        }
        return true;
          }
            catch (Exception e)
            {
              Console.WriteLine(e.Message);
              return false;
            }
    
    }
     
    public bool Save()
    {
      try{
           
           StreamWriter writer = new StreamWriter(this.file);
           foreach (KeyValuePair<string, string> kvp in this.translateWords)
           {
               writer.WriteLine(kvp.Key + ":" + kvp.Value);
           }
           writer.Close();
           return true;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return false;
      }
    }

    public string Translate(string word)
    {
      if (this.translateWords.ContainsKey(word))
      {
        return this.translateWords[word];
      }
      foreach (KeyValuePair<string, string> words in this.translateWords)
      {
          if(words.Value == word)
          {
            return words.Key;
          }
      }
      {
        return null;
      }
    }

    public void Delete(string word)
    {
      foreach (KeyValuePair<string, string> words in this.translateWords)
      {
        if(words.Key == word || words.Value == word)
        {
          this.translateWords.Remove(words.Key);
        }
      }
        
    }
  }
}