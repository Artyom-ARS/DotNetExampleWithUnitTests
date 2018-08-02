namespace ConsoleApp
{
  public class ApplicationControllerTestable
  {
    public int ApplicationState;

    private readonly IGameField _gameField;

    public ApplicationControllerTestable(IGameField gameField)
    {
      _gameField = gameField;
    }

    public ApplicationControllerTestable()
    {
      _gameField = new GameField();
    }

    public void Run ()
    {
      ApplicationState = _gameField.Build(10, 0);
      //_applicationState.Add();
    }
  }
}
