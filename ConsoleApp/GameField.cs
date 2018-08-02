using System;

namespace ConsoleApp
{
  public class GameField : IGameField
  {
    private readonly IConsoleFacade _consoleFacade;

    public GameField(IConsoleFacade consoleFacade)
    {
      _consoleFacade = consoleFacade;
    }

    public GameField()
    {
      _consoleFacade = new ConsoleFacade();
    }

    public int Build(int width, int height)
    {
      if (width <= 0 || height <= 0)
      {
        throw new Exception("Wrong input parameters");
      }

      if (width == height)
      {
        return 100;
      }

      var size = width * height;
      return size;
    }

    public int BuildRandom()
    {
      var random = new Random();
      var width = random.Next() % 100;
      var height = random.Next() % 100;
      return Build(width, height);
    }

    public int RequestInput()
    {
      var input = _consoleFacade.ReadLine();
      // old code
      //var input = Console.ReadLine();

      // do something with input
      int.TryParse(input, out var result);

      return result;
    }
  }

}