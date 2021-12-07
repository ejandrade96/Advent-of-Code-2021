using System;
using System.Collections.Generic;
using System.IO;

namespace Dia01_varredura_do_sonar.Classes
{
  public class Parte1 : Desafio
  {
    public override int Resolver()
    {
      var medicoesProfundidade = File.ReadAllLines("./Dados/medicoes.txt");
      var medidasAumentadas = 0;

      for (var i = 1; i < medicoesProfundidade.Length; i++)
      {
        var medicaoAtual = Convert.ToInt32(medicoesProfundidade[i]);
        var medicaoAnterior = Convert.ToInt32(medicoesProfundidade[i - 1]);

        if (medicaoAtual > medicaoAnterior)
          medidasAumentadas++;
      }

      return medidasAumentadas;
    }
  }
}