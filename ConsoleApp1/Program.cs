using LayerOne;
using LayerThree;
using LayerTwo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("Pressione ENTER para iniciar");
      Console.ReadLine();
      

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
      Console.WriteLine("\n Pressione ENTER para iniciar Paralela");
      Console.ReadLine();

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
