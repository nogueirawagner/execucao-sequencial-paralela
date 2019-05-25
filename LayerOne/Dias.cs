using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LayerOne
{
  public static class Dias
  {
    public static void ExibirDias()
    {
      string[] diasArray = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };
      foreach (string dia in diasArray)
      {
        Console.WriteLine("Dia da semana: {0}", dia);
        Thread.Sleep(500);
      }
    }
  }
}
