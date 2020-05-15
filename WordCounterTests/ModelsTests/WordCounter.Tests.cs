using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {

    }
    [TestMethod]
    public void UserInput_IsUserInputWordAString_True()
    {
      // Arrange
      Logic testOne = new Logic();
      // Act
      testOne.GetInputWord("cat");
      // Assert
      Assert.AreEqual(typeof(string), testOne.InputWord.GetType());
    }

    [TestMethod]
    public void UserInput_IsUserInputSentenceAString_True()
    {
      // Arrange
      Logic testTwo = new Logic();
      // Act
      testTwo.GetInputString("the cat was at the cathedral");
      // Assert
      Assert.AreEqual(typeof(string[]), testTwo.InputString.GetType());
      Console.WriteLine()
    }
  }
}