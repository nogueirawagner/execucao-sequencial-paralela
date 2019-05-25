using System;
using System.Threading;

namespace LayerThree
{
  public static class Meses
  {
    public static void ExibirMeses()
    {
      string[] messArray = { "Jan", "Fev", "Mar", "Abr","Mai", "Jun", "Jul",
                                   "Ago", "Set", "Out", "Nov", "Dec" };

      foreach (string mes in messArray)
      {
        Console.WriteLine("Mês : {0}", mes);
        Thread.Sleep(500);
      }
    }
  }
}
