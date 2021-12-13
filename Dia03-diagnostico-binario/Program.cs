using System;
using Dia03_diagnostico_binario.Classes;

namespace Dia03_diagnostico_binario
{
  class Program
  {
    static void Main(string[] args)
    {
      DesafioParte1 desafio1 = new DesafioParte1();
      DesafioParte2 desafio2 = new DesafioParte2();
      
      Console.WriteLine(desafio1.Resolver());
      Console.WriteLine(desafio2.Resolver());
    }
  }
}
