using System;
using Dia02_mergulho.Classes;

namespace Dia02_mergulho
{
  class Program
  {
    static void Main(string[] args)
    {
      DesafioParte1 desafio = new DesafioParte1();

      var resultado = desafio.Resolver();

      Console.WriteLine(resultado);
    }
  }
}
