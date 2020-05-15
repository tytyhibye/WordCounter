using System;
using WordCounter.Models;

namespace CounterEntry
{
  class Program
  {
    public static void Main()
    {
      Logic frontEnd = new Logic();
      Console.WriteLine("Welcome to the Word Counter.\n\n  Please Enter a Word:");
      string inputWord = Console.ReadLine();
      Console.WriteLine("Now enter a sentence or phrase to see if it contains the entered word:");
      string inputString = Console.ReadLine();
      
      frontEnd.GetInputWord(inputWord);
      frontEnd.GetInputString(inputString);
    }

  }
}