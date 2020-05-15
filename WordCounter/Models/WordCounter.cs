using System;


namespace WordCounter.Models
{
  public class Logic
  {
    public string InputWord { get; set; }
    public string[] InputString { get; set; }
    public int WordCount { get; set; }
    
    public void GetInputWord(string inputWord)
    {
      InputWord = inputWord.ToLower();
    }

    public void GetInputString(string inputString)
    {
      InputString = (inputString.ToLower()).Split();
    }

    public void RepeatCounter()
    {
      foreach(string word in InputString)
      {
        if(word == InputWord)
        {
          WordCount += 1;
        }
      }
    }
  }
}