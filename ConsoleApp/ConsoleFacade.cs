using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp
{
  [ExcludeFromCodeCoverage]
  public class ConsoleFacade : IConsoleFacade
  {
    public string ReadLine()
    {
      return Console.ReadLine();
    }

    public void WriteLine(string format, object args)
    {
      Console.WriteLine(format, args);
    }
  }
}