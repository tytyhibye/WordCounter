using System;


namespace WordCounter.Models
{
  public class Logic
  {
    public string InputWord { get; set; }
    public string[] InputString { get; set; }
    
    public void GetInputWord(string inputWord)
    {
      InputWord = inputWord.ToLower();
    }

    public void GetInputString(string inputString)
    {
      InputString = (inputString.ToLower()).Split();
    }

    // public void CompareInputs()
    // {

    // }
  }
}