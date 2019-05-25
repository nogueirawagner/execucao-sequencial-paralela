using System;
using System.Threading;

namespace LayerTwo
{
  public static class Cidades
  {
    public static void ExibirCidades()
    {
      string[] cidadesArray = { "Londres", "New York", "Paris", "Tóquio", "Sidney", "Anápolis" };
      foreach (string cidade in cidadesArray)
      {
        Console.WriteLine("Cidade : {0}", cidade);
        Thread.Sleep(500);
      }
    }
  }
}
