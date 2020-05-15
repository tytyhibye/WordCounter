using System;
using WordCounter.Models;

namespace WordCounterEntry
{
  class Program
  {
    public static void Main()
    {
      Logic frontEnd = new Logic();

      Console.WriteLine(@"
          Welcome to my
    ▄▄▌ ▐ ▄▌      ▄▄▄  ·▄▄▄▄        
    ██· █▌▐█▪     ▀▄ █·██▪ ██       
    ██▪▐█▐▐▌ ▄█▀▄ ▐▀▀▄ ▐█· ▐█▌      
    ▐█▌██▐█▌▐█▌.▐▌▐█•█▌██. ██       
     ▀▀▀▀ ▀▪ ▀█▄▀▪.▀  ▀▀▀▀▀▀•       
 ▄▄·       ▄• ▄▌ ▐ ▄ ▄▄▄▄▄▄▄▄ .▄▄▄  
▐█ ▌▪▪     █▪██▌•█▌▐█•██  ▀▄.▀·▀▄ █·
██ ▄▄ ▄█▀▄ █▌▐█▌▐█▐▐▌ ▐█.▪▐▀▀▪▄▐▀▀▄ 
▐███▌▐█▌.▐▌▐█▄█▌██▐█▌ ▐█▌·▐█▄▄▌▐█•█▌
·▀▀▀  ▀█▄▀▪ ▀▀▀ ▀▀ █▪ ▀▀▀  ▀▀▀ .▀  ▀");
    Console.WriteLine("       Please enter a word:")
      string inputWord = Console.ReadLine();
      
      Console.WriteLine("Now enter a sentence or phrase to see if it contains the entered word:");
      string inputString = Console.ReadLine();
      
      frontEnd.GetInputWord(inputWord);
      frontEnd.GetInputString(inputString);
      frontEnd.RepeatCounter();

      Console.WriteLine("\n\n\n\tthe word: '" + frontEnd.InputWord + "'");
      Console.WriteLine("\n\n\tthe number of occurances in the input sentence: " + frontEnd.WordCount + "!");
    }
  }
}