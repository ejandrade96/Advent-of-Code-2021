namespace Dia02_mergulho.Classes
{
  public class Submarino
  {
    public int PosicaoHorizontal { get; private set; }

    public int Profundidade { get; private set; }

    public string[] Instrucoes { get; private set; }

    public Submarino(string[] instrucoes)
    {
      Instrucoes = instrucoes;
    }

    public void Limpar()
    {
      PosicaoHorizontal = 0;
      Profundidade = 0;
    }

    public void LerInterpretarInstrucoes()
    {
      Limpar();

      for (var i = 0; i < Instrucoes.Length; i++)
      {
        var instrucao = Instrucoes[i].Split(' ');
        var direcao = instrucao[0].ToLower();
        var aumentoDirecao = int.Parse(instrucao[1]);

        Mover(direcao, aumentoDirecao);
      }
    }

    public int ObterCalculoPosicaoHorizontalEProfundidade() => PosicaoHorizontal * Profundidade;

    private void SeguirEmFrente(int qtdVezes) => PosicaoHorizontal += qtdVezes;

    private void Descer(int qtdVezes) => Profundidade += qtdVezes;

    private void Subir(int qtdVezes) => Profundidade -= qtdVezes;

    private void Mover(string direcao, int quantidade)
    {
      switch (direcao)
      {
        case "forward":
          SeguirEmFrente(quantidade);
          break;

        case "down":
          Descer(quantidade);
          break;

        case "up":
          Subir(quantidade);
          break;

        default:
          break;
      }
    }
  }
}