### Dia 1: varredura do sonar

Você está cuidando da sua vida em um navio no mar quando o alarme ao mar dispara! Você corre para ver se pode ajudar. Aparentemente, um dos elfos tropeçou e acidentalmente enviou as chaves do trenó voando para o oceano!

Antes que você perceba, você está dentro de um submarino que os Elfos mantêm prontos para situações como esta. É coberto por luzes de Natal (porque é claro) e tem até uma antena experimental que deve ser capaz de rastrear as teclas se você puder aumentar a intensidade do sinal o suficiente; há um pequeno medidor que indica a força do sinal da antena exibindo 0-50 estrelas .

Seus instintos lhe dizem que, para salvar o Natal, você precisará obter todas as cinquenta estrelas até 25 de dezembro.

Colete estrelas resolvendo quebra-cabeças. Dois quebra-cabeças serão disponibilizados a cada dia no calendário do Advento; o segundo quebra-cabeça é desbloqueado quando você completa o primeiro. Cada quebra-cabeça concede uma estrela . Boa sorte!


#### Parte 1

Conforme o submarino cai abaixo da superfície do oceano, ele executa automaticamente uma varredura de sonar do fundo do mar próximo. Em uma pequena tela, o relatório de varredura do sonar (sua entrada no quebra-cabeça) aparece: cada linha é uma medida da profundidade do fundo do mar à medida que a varredura se afasta cada vez mais do submarino.

Por exemplo, suponha que você tenha o seguinte relatório:

199\
200\
208\
210\
200\
207\
240\
269\
260\
263

Este relatório indica que, a digitalização para fora do submarino, a varredura sonar encontrado profundezas 199, 200, 208, 210, e assim por diante.

A primeira coisa a fazer é descobrir com que rapidez a profundidade aumenta, apenas para que você saiba com o que está lidando - você nunca sabe se as chaves serão carregadas para águas mais profundas por uma corrente do oceano ou por um peixe ou algo assim.

Para fazer isso, conte o número de vezes que uma medição de profundidade aumenta em relação à medição anterior. (Não há medição antes da primeira medição.) No exemplo acima, as alterações são as seguintes:

199 (N/A - no previous measurement)\
200 (increased)\
208 (increased)\
210 (increased)\
200 (decreased)\
207 (increased)\
240 (increased)\
269 (increased)\
260 (decreased)\
263 (increased)

Neste exemplo, existem 7medidas que são maiores do que a medida anterior.

Quantas medições são maiores do que a medição anteriors?

Para começar, obtenha informações sobre o quebra-cabeça. (path: Dados/medicoes.txt)


#### Parte 2

Considerando que cada medição não é tão útil quanto você esperava: há muito ruído nos dados.

Em vez disso, considere somas de uma janela deslizante de três medidas . Considerando novamente o exemplo acima:

![print-exemplo-janela-tres-medidas](https://user-images.githubusercontent.com/57911863/145736303-f9552a45-edf8-42e4-b113-70905d4c698b.png)

Comece comparando a primeira e a segunda janela de três medições. As medições na primeira janela são marcados A( 199, 200, 208); sua soma é 199 + 200 + 208 = 607. A segunda janela estiver marcada B( 200, 208, 210); sua soma é 618. A soma das medidas na segunda janela é maior do que a soma da primeira, portanto, esta primeira comparação aumentou .

Seu objetivo agora é contar o número de vezes que a soma das medições nesta janela deslizante aumenta em relação à soma anterior. Portanto, compare Acom B, compare Bcom C, depois Ccom De assim por diante. Pare quando não houver medidas suficientes para criar uma nova soma de três medidas.

No exemplo acima, a soma de cada janela de três medições é a seguinte:

A: 607 (N/A - no previous sum)\
B: 618 (increased)\
C: 618 (no change)\
D: 617 (decreased)\
E: 647 (increased)\
F: 716 (increased)\
G: 769 (increased)\
H: 792 (increased)

Neste exemplo, existem 5somas maiores do que a soma anterior.

Considere somas de uma janela deslizante de três medidas. Quantas somas são maiores do que a soma anterior?

Embora não tenha mudado, você ainda pode obter informações sobre o quebra-cabeça. (path: Dados/medicoes.txt)
