using System;
using Dia02_mergulho.Classes;

namespace Dia02_mergulho
{
  class Program
  {
    static void Main(string[] args)
    {
      // DesafioParte1 desafio = new DesafioParte1();
      DesafioParte2 desafio = new DesafioParte2();

      var resultado = desafio.Resolver();

      Console.WriteLine(resultado);
    }
  }
}
