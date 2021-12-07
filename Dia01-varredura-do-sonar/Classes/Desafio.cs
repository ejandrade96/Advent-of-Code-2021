using System;
using System.IO;

namespace Dia01_varredura_do_sonar.Classes
{
  public abstract class Desafio
  {
    protected string[] MedicoesProfundidade { get; private set; }

    public Desafio()
    {
      MedicoesProfundidade = File.ReadAllLines("./Dados/medicoes.txt");
    }

    public abstract string Resolver();

    public virtual int VerificarQuantidadeAumentoMedicoes(string[] medicoes)
    {
      var medidasAumentadas = 0;

      for (var i = 1; i < medicoes.Length; i++)
      {
        var medicaoAtual = Convert.ToInt32(medicoes[i]);
        var medicaoAnterior = Convert.ToInt32(medicoes[i - 1]);

        if (medicaoAtual > medicaoAnterior)
          medidasAumentadas++;
      }

      return medidasAumentadas;
    }
  }
}