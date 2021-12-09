using System.IO;

namespace Dia02_mergulho.Classes
{
  public class DesafioParte2
  {
    public string Resolver()
    {
      string[] instrucoes = File.ReadAllLines("./Dados/instrucoes-submarino.txt");

      var objetivo = 0;
      var posicaoHorizontal = 0;
      var profundidade = 0;

      for (var i = 0; i < instrucoes.Length; i++)
      {
        var instrucao = instrucoes[i].Split(' ');
        var direcao = instrucao[0].ToLower();
        var aumentoDirecao = int.Parse(instrucao[1]);

        if (direcao == "forward")
        {
          posicaoHorizontal += aumentoDirecao;

          if (objetivo > 0)
            profundidade += aumentoDirecao * objetivo;
        }

        else if (direcao == "down")
          objetivo += aumentoDirecao;

        else
          objetivo -= aumentoDirecao;
      }

      return $"O resultado da 2º parte do desafio é: { posicaoHorizontal * profundidade }.";
    }
  }
}