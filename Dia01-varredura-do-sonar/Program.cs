using System;
using Dia01_varredura_do_sonar.Classes;

namespace Dia01_varredura_do_sonar
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Desafio do 1º dia: Você gostaria da resposta da primeira ou segunda parte? (Por favor, digite apenas 1 ou 2)");
      var parte = int.Parse(Console.ReadLine());
      Desafio desafio;

      if (parte == 1)
        desafio = new DesafioParte1();

      else
        desafio = new DesafioParte2();

      var resultado = desafio.Resolver();

      Console.WriteLine(resultado);
    }
  }
}
