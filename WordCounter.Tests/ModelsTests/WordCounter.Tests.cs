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
      // in case it's needed.
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
    public void UserInput_IsUserInputSentenceAnArray_True()
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
      Assert.AreEqual(3, testFour.WordCount);
    }

    [TestMethod]
    public void RepeatCounter_ReturnsTheNumberOfOccurences_True()
    {
      // Arrange
      Logic testFive = new Logic();
      // Act
      testFive.GetInputWord("cat");
      testFive.GetInputString("cathy the cat was at the cathedral.");
      testFive.RepeatCounter();
      // Assert
      Assert.AreEqual(1, testFive.WordCount);
    }
  }
}