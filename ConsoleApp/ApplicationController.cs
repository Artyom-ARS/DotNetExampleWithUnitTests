using System.Collections.Generic;

namespace ConsoleApp
{
  public class ApplicationController
  {
    public IList<string> ApplicationState;

    public void Run ()
    {
      ApplicationState = new List<string>();
      var gameField = new GameField();
      var state = gameField.Build(10, 0);
    }
  }
}
