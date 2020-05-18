using System.Collections.Generic;

namespace Exercise
{
  public class DictionaryOfManyTranslations
  {
    private Dictionary<string, List<string>> translatedWords;

    public DictionaryOfManyTranslations()
    {
      this.translatedWords = new Dictionary<string, List<string>>();
    }

    public void Add(string word, string translation)
    {
       if (!this.translatedWords.ContainsKey(word))
       {
         this.translatedWords.Add(word, new List<string>());
       }
       List<string> translated = this.translatedWords[word];
       translated.Add(translation);
    }

    public List<string> Translate(string word)
    {
      if (!this.translatedWords.ContainsKey(word))
      {
        this.translatedWords.Add(word, new List<string>()); 
      }
      return this.translatedWords[word];
    }

    public void Remove(string word)
    {
      if (this.translatedWords.ContainsKey(word))
      {
        this.translatedWords.Remove(word);
      }
    }
  }
}