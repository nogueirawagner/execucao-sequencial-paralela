using LayerOne;
using LayerThree;
using LayerTwo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Populando List com 100.000 registros com sleep de 2 ms para cada registro");
      Console.WriteLine("Tempo estimado de =~ 3 minutos \n\n");

      Console.WriteLine("For sequencial\n");
      var lista1 = new List<string>();
      var swFor = new Stopwatch();
      swFor.Start();
      for (int i = 0; i < 100000; i++)
      {
        Thread.Sleep(2);
        lista1.Add(string.Format("item-{0}", i));
      }

      swFor.Stop();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"\n Tempo passado para execução sequencial: {swFor.Elapsed}");
      Console.ResetColor();

      Console.WriteLine("----------------------------------------");

      // ---------------------- ------------- --------------
      Console.WriteLine("\n For Paralelo \n");
      var lista2 = new List<string>();
      var swForParl = new Stopwatch();
      swForParl.Start();
      Parallel.For(0, 100000, i =>
      {
        Thread.Sleep(2);
        lista2.Add(string.Format("item-{0}", i));
      });

      swForParl.Stop();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"\n Tempo passado para execução paralela: {swForParl.Elapsed}");
      Console.ResetColor();

      Console.WriteLine("\n ----------------------------------------");

      Console.WriteLine("\n Exibindo cidades sequenciais \n");

      var stopwatch = new Stopwatch();
      stopwatch.Start();
      Console.WriteLine("\n Sequencial");
      Dias.ExibirDias();
      Meses.ExibirMeses();
      Cidades.ExibirCidades();

      stopwatch.Stop();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"\n Tempo passado: {stopwatch.Elapsed}");
      Console.ResetColor();

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("\n Exibindo cidades paralela com invoke");
      Console.ResetColor();

      var stopwatch2 = new Stopwatch();
      stopwatch2.Start();
      // Invocar os métodos que vamos executar
      Parallel.Invoke(
      new Action(Dias.ExibirDias),
      new Action(Meses.ExibirMeses),
      new Action(Cidades.ExibirCidades)
      );

      stopwatch2.Stop();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"\n Tempo passado: {stopwatch2.Elapsed}");
      Console.ResetColor();

      // Aguardar a continuação do programa
      Console.WriteLine("nO método Main foi encerrado. Tecle Enter");
      Console.ReadLine();
    }
  }
}
