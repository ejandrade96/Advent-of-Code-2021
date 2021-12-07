using System;
using Dia01_varredura_do_sonar.Classes;

namespace Dia01_varredura_do_sonar
{
  class Program
  {
    static void Main(string[] args)
    {
      Desafio desafio = new Parte1();
      var resultado = desafio.Resolver();

      Console.WriteLine(resultado);
    }
  }
}
