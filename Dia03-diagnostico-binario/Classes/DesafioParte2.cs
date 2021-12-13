using System;
using System.Collections.Generic;
using Dia03_diagnostico_binario.Enum;

namespace Dia03_diagnostico_binario.Classes
{
  public class DesafioParte2 : Desafio
  {
    public override string Resolver()
    {
      var suporteDeVida = ObterClassificacaoEmDecimal(Classificacao.GeradorOxigenio) * ObterClassificacaoEmDecimal(Classificacao.PurificadorCO2);

      return $"O resultado da 2º parte do desafio é: {suporteDeVida}";
    }

    private string ObterClassificacaoEmBinario(Classificacao classificacao)
    {
      string[] relatorioDiagnosticoTemp = RelatorioDiagnosticoEmBinario;

      var numerosAgrupadosPorCriterioBit0 = new List<string>();
      var numerosAgrupadosPorCriterioBit1 = new List<string>();

      for (var i = 0; i < QuantidadeBitsPorNumero; i++)
      {
        for (var j = 0; j < relatorioDiagnosticoTemp.Length; j++)
        {
          var numeroBinario = relatorioDiagnosticoTemp[j];

          if (numeroBinario.Substring(i, 1) == "0")
            numerosAgrupadosPorCriterioBit0.Add(numeroBinario);

          else
            numerosAgrupadosPorCriterioBit1.Add(numeroBinario);
        }

        relatorioDiagnosticoTemp = ObterNovoRelatorioComBaseNaClassificacao(classificacao, numerosAgrupadosPorCriterioBit0, numerosAgrupadosPorCriterioBit1);

        numerosAgrupadosPorCriterioBit0.Clear();
        numerosAgrupadosPorCriterioBit1.Clear();

        if (relatorioDiagnosticoTemp.Length == 1)
          break;
      }

      return relatorioDiagnosticoTemp[0];
    }

    private string[] ObterNovoRelatorioComBaseNaClassificacao(Classificacao classificacao, List<string> numerosAgrupadosPorCriterioBit0, List<string> numerosAgrupadosPorCriterioBit1)
    {
      if (classificacao.Equals(Classificacao.GeradorOxigenio))
      {
        if (numerosAgrupadosPorCriterioBit1.Count > numerosAgrupadosPorCriterioBit0.Count || numerosAgrupadosPorCriterioBit0.Count == numerosAgrupadosPorCriterioBit1.Count)
          return numerosAgrupadosPorCriterioBit1.ToArray();

        else
          return numerosAgrupadosPorCriterioBit0.ToArray();
      }
      else
      {
        if (numerosAgrupadosPorCriterioBit0.Count < numerosAgrupadosPorCriterioBit1.Count || numerosAgrupadosPorCriterioBit0.Count == numerosAgrupadosPorCriterioBit1.Count)
          return numerosAgrupadosPorCriterioBit0.ToArray();

        else
          return numerosAgrupadosPorCriterioBit1.ToArray();
      }
    }

    private int ObterClassificacaoEmDecimal(Classificacao classificacao) => Convert.ToInt32(ObterClassificacaoEmBinario(classificacao), 2);
  }
}
