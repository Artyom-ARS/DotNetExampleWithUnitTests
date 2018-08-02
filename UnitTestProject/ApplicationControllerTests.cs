using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
  [TestClass]
  public class ApplicationControllerTests
  {
    private ApplicationControllerTestable _testClass;

    [TestInitialize]
    public void SetUp()
    {
      var gameFieldMock = new GameFieldMock();
      _testClass = new ApplicationControllerTestable(gameFieldMock);
    }


    [TestMethod]
    public void Given_value_When_method_Then()
    {
      // Given


      // When
      _testClass.Run();

      // Then
      Assert.AreEqual(20, _testClass.ApplicationState);

    }
  }

  public class GameFieldMock: IGameField
  {
    public int Build(int width, int height)
    {
      return 20;
    }

    public int BuildRandom()
    {
      return 10;
    }
  }
}
