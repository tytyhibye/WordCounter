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
    }

    [TestMethod]
    public void CompareInputs_ReturnsCountOfOccurencesInString_True()
    {
      // Arrange
      Logic testThree = new Logic();
      // Act
      testThree.GetInputWord("cat");
      testThree.GetInputString("The Cat Was At The Cathedral");
      testThree.RepeatCounter();
      // Assert
      Assert.AreEqual(1, testThree.WordCount);
    }

    [TestMethod]
    public void CompareInputs_RemovesPunctuationFromInputString_True()
    {
      // Arrange
      Logic testFour = new Logic();
      // Act
      testFour.GetInputWord("cat");
      testFour.GetInputString("cat,cat.cats!cat");
      testFour.RepeatCounter();
      // Assert
      Assert.AreEqual(1, testFour.WordCount);
    }
  }
}