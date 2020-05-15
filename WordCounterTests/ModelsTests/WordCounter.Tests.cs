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
    public void UserInput_IsUserInputAString_True()
    {
      // Arrange
      Logic testOne = new Logic();
      // Act
      testOne.GetInput("cat");
      // Assert
      Assert.AreEqual(typeof(string), testOne.InputWord.GetType());
    }
  }
}