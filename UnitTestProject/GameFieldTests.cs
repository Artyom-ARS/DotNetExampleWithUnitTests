using System;
using System.Collections.Generic;
using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
  [TestClass]
  public class GameFieldTests
  {
    private GameField _testClass;

    [TestInitialize]
    public void SetUp()
    {
      var consoleFacade = new ConsoleFacadeMock();
      _testClass = new GameField(consoleFacade);
    }

    [TestMethod]
    public void Given_negative_width_and_height_When_Build_Then_return_zero()
    {
      // Given
      const int x = -1;
      var c = new List<string>();
      var testClass = new GameField();

      // When
      var result = testClass.Build(x, -1);

      // Then
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Given_width_equal_height_When_Build_Then_return_100()
    {
      // Given
      var testClass = new GameField();

      // When
      var result = testClass.Build(2, 2);

      // Then
      Assert.AreEqual(100, result);

    }

    [TestMethod]
    public void Given_width_not_equal_height_When_Build_Then_return_multiplication()
    {
      // Given
      var testClass = new GameField();

      // When
      var result = testClass.Build(3, 2);

      // Then
      Assert.AreEqual(6, result);

    }

    [TestMethod]
    public void Given_negative_width_and_height_When_Build_Then_throw_exception()
    {
      // Given
      var testClass = new GameField();

      // When
      // Then
      Assert.ThrowsException<Exception>(() => testClass.Build(-1, -1));

    }

    [TestMethod]
    public void Given_some_input_When_RequestInput_Then_return_value()
    {
      // Given
    
      // When
      var result = _testClass.RequestInput();

      // Then
      Assert.AreEqual(6, result);

    }

    [TestMethod]
    public void Given_nothing_When_BuildRandom_Then_return_value()
    {
      // Given
      var testClass = new GameField();

      // When
      var result = testClass.BuildRandom();

      // Then
      Assert.AreEqual(6, result);

    }
  }

  public class ConsoleFacadeMock: IConsoleFacade
  {
    public string ReadLine()
    {
      return "6";
    }
  }
}
