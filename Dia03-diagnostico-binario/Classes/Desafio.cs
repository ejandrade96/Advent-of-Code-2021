using System.IO;

namespace Dia03_diagnostico_binario.Classes
{
  public abstract class Desafio
  {
    protected string[] RelatorioDiagnosticoEmBinario { get; private set; }

    protected int QuantidadeBitsPorNumero { get; private set; }

    public Desafio()
    {
      RelatorioDiagnosticoEmBinario = File.ReadAllLines("./Dados/relatorio-de-diagnostico.txt");
      QuantidadeBitsPorNumero = RelatorioDiagnosticoEmBinario[0].Length;
    }

    public abstract string Resolver();
  }
}