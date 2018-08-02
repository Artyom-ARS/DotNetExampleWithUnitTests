namespace ConsoleApp
{
  public interface IGameField
  {
    int Build(int width, int height);
    int BuildRandom();
  }
}