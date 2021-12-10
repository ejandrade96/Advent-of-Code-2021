#### Dia 3: Diagnóstico Binário ---

O submarino tem feito alguns ruídos estranhos , então você pede a ele para produzir um relatório de diagnóstico para o caso.

O relatório de diagnóstico (sua entrada no quebra-cabeça) consiste em uma lista de números binários que, quando decodificados corretamente, podem lhe dizer muitas coisas úteis sobre as condições do submarino. O primeiro parâmetro a verificar é o consumo de energia.

Você precisa usar os números binários no relatório de diagnóstico para gerar dois novos números binários (chamados de taxa gama e taxa épsilon ). O consumo de energia pode então ser encontrado multiplicando a taxa gama pela taxa épsilon.

Cada bit na taxa gama pode ser determinado encontrando o bit mais comum na posição correspondente de todos os números no relatório de diagnóstico. Por exemplo, dado o seguinte relatório de diagnóstico:

00100
11110
10110
10111
10101
01111
00111
11100
10000
11001
00010
01010

Considerando apenas o primeiro bit de cada número, existem cinco 0bits e sete 1bits. Como o bit mais comum é 1, o primeiro bit da taxa gama é 1.

O segundo bit mais comum dos números no relatório de diagnóstico é 0, portanto, o segundo bit da taxa gama é 0.

O valor mais comum dos terceiro, quarto e quinto bits são 1, 1, e 0, respectivamente, e de modo que os três últimos bits da taxa gama são 110.

Portanto, a taxa gama é o número binário 10110, ou 22decimal.

A taxa épsilon é calculada de maneira semelhante; em vez de usar o bit mais comum, é usado o bit menos comum de cada posição. Portanto, a taxa épsilon é 01001, ou 9em decimal. Multiplicar a taxa gama ( 22) pela taxa épsilon ( 9) produz o consumo de energia 198,.

Use os números binários em seu relatório de diagnóstico para calcular a taxa gama e a taxa épsilon e, em seguida, multiplique-os. Qual é o consumo de energia do submarino? (Certifique-se de representar sua resposta em decimal, não binário.)

Para começar, obtenha informações sobre o quebra-cabeça. (path: Dados/relatorio-de-diagnostico.txt)
