using System;

namespace Dia03_diagnostico_binario.Classes
{
  public class DesafioParte1 : Desafio
  {
    public override string Resolver()
    {
      var taxaGama = "";
      var taxaEpsilon = "";
      var qtdBit0 = 0;
      var qtdBit1 = 0;

      for (var i = 0; i < QuantidadeBitsPorNumero; i++)
      {
        for (var j = 0; j < RelatorioDiagnosticoEmBinario.Length; j++)
        {
          var numeroBinario = RelatorioDiagnosticoEmBinario[j];
          var bit = numeroBinario[i].ToString();

          if (bit == "0")
            qtdBit0++;

          else
            qtdBit1++;
        }

        if (qtdBit0 > qtdBit1)
        {
          taxaGama += "0";
          taxaEpsilon += "1";
        }
        else
        {
          taxaGama += "1";
          taxaEpsilon += "0";
        }

        qtdBit0 = 0;
        qtdBit1 = 0;
      }

      return $"O resultado da 1º parte do desafio é: {Convert.ToInt32(taxaGama, 2) * Convert.ToInt32(taxaEpsilon, 2)}";
    }
  }
}