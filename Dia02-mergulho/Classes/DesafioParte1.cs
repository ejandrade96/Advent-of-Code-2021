using System.IO;

namespace Dia02_mergulho.Classes
{
  public class DesafioParte1
  {
    public string Resolver()
    {
      var instrucoesSubmarino = File.ReadAllLines("./Dados/instrucoes-submarino.txt");

      var submarino = new Submarino(instrucoesSubmarino);
      submarino.LerInterpretarInstrucoes();

      return $"O resultado da 1º parte do desafio é: {submarino.ObterCalculoPosicaoHorizontalEProfundidade()}.";
    }
  }
}