using System;

namespace Dia01_varredura_do_sonar.Classes
{
  public class DesafioParte2 : Desafio
  {
    public override string Resolver()
    {
      int qtdJanelasTresMedidas = MedicoesProfundidade.Length - 2;
      var janelasTresMedidas = new string[qtdJanelasTresMedidas];
      bool arrayJanelasTresMedidasCheio = Convert.ToInt32(janelasTresMedidas[janelasTresMedidas.Length - 1]) > 0;

      for (var i = 0; i < MedicoesProfundidade.Length - 2; i++)
      {
        int soma, medida1, medida2, medida3 = 0;

        if (!arrayJanelasTresMedidasCheio)
        {
          medida1 = Convert.ToInt32(MedicoesProfundidade[i]);
          medida2 = Convert.ToInt32(MedicoesProfundidade[i + 1]);
          medida3 = Convert.ToInt32(MedicoesProfundidade[i + 2]);
          soma = medida1 + medida2 + medida3;
          janelasTresMedidas[i] = soma.ToString();
        }
      }

      return $"O resultado da 2º parte do desafio é: {VerificarQuantidadeAumentoMedicoes(janelasTresMedidas)}.";
    }
  }
}