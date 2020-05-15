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
      
      frontEnd.GetInput(inputWord);
    }

  }
}