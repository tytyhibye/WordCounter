using System;


namespace WordCounter.Models
{
  public class Logic
  {
    public string InputWord { get; set; }
    
    public void GetInput(string inputWord)
    {
      InputWord = inputWord.ToLower();
    }
  }
}