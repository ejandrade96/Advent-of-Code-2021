using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dia04_lula_gigante.Classes
{
  public class DesafioParte1
  {
    protected string[] NumerosSorteadosBingo { get; private set; }

    protected List<string[,]> CartelasBingo { get; private set; }

    public DesafioParte1()
    {
      NumerosSorteadosBingo = File.ReadAllText("./Dados/numeros-sorteados-bingo.txt").Split(',');
      CartelasBingo = new List<string[,]>();
      LerCartelasBingo();
    }

    public string Resolver()
    {
      foreach (var numeroSorteado in NumerosSorteadosBingo)
      {
        foreach (var cartela in CartelasBingo)
        {
          for (int linha = 0; linha < cartela.GetLength(0); linha++)
          {
            for (int coluna = 0; coluna < cartela.GetLength(1); coluna++)
            {
              var numeroAtualCartela = cartela[linha, coluna];

              if (numeroAtualCartela == numeroSorteado)
              {
                cartela[linha, coluna] = "";

                bool cartelaVencedora = VerificarCartelaVencedora(cartela);

                if (cartelaVencedora)
                {
                  return $"O resultado da 1º parte do desafio é: {ObterPontuacaoCartelaVencedora(cartela, numeroAtualCartela)}.";
                }
              }
            }
          }
        }
      }

      return "Não houve vencedor";
    }

    private void LerCartelasBingo()
    {
      var dadosCartelas = File.ReadAllLines("./Dados/cartelas-bingo.txt");
      var cartelaTemp = new string[5, 5];
      int contadorLinhaTemp = 0;

      for (int linhaDadosCartelas = 0; linhaDadosCartelas <= dadosCartelas.Length; linhaDadosCartelas++)
      {
        var numerosLinha = "";

        try
        {
          numerosLinha = dadosCartelas[linhaDadosCartelas];
        }
        catch (Exception)
        {
          numerosLinha = "";
        }

        if (!string.IsNullOrEmpty(numerosLinha) && linhaDadosCartelas != dadosCartelas.Length)
        {
          // Remover dois espaços em branco da string
          var numerosLinhaEmArray = new Regex("[ ]{2,}", RegexOptions.None).Replace(numerosLinha.Trim(), " ").Split(" ");

          for (int coluna = 0; coluna < numerosLinhaEmArray.Length; coluna++)
          {
            cartelaTemp[contadorLinhaTemp, coluna] = numerosLinhaEmArray[coluna];
          }

          contadorLinhaTemp++;
        }
        else
        {
          CartelasBingo.Add(cartelaTemp);
          contadorLinhaTemp = 0;
          cartelaTemp = new string[5, 5];
        }
      }
    }

    private bool VerificarCartelaVencedora(string[,] cartela)
    {
      var numerosLinhaAtualCartelaTemp = new List<string>();
      var numerosColunaAtualCartelaTemp = new List<string>();
      bool cartelaVenceu = false;

      for (int linha = 0; linha < cartela.GetLength(0); linha++)
      {
        if (cartelaVenceu)
          break;

        for (int coluna = 0; coluna < cartela.GetLength(1); coluna++)
        {
          numerosLinhaAtualCartelaTemp.Add(cartela[linha, coluna]);
          numerosColunaAtualCartelaTemp.Add(cartela[coluna, linha]);
        }

        if (numerosLinhaAtualCartelaTemp.All(x => string.IsNullOrEmpty(x)) || numerosColunaAtualCartelaTemp.All(x => string.IsNullOrEmpty(x)))
          cartelaVenceu = true;

        else
        {
          numerosLinhaAtualCartelaTemp.Clear();
          numerosColunaAtualCartelaTemp.Clear();
        }
      }

      return cartelaVenceu;
    }

    private int ObterPontuacaoCartelaVencedora(string[,] cartela, string ultimoNumeroSorteado)
    {
      var somaNumerosCartela = 0;

      foreach (var numero in cartela)
      {
        if (!string.IsNullOrEmpty(numero))
          somaNumerosCartela += int.Parse(numero);
      }

      return somaNumerosCartela * int.Parse(ultimoNumeroSorteado);
    }
  }
}