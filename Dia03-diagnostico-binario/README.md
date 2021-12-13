### Dia 3: Diagnóstico Binário

O submarino tem feito alguns ruídos estranhos , então você pede a ele para produzir um relatório de diagnóstico para o caso.

O relatório de diagnóstico (sua entrada no quebra-cabeça) consiste em uma lista de números binários que, quando decodificados corretamente, podem lhe dizer muitas coisas úteis sobre as condições do submarino. O primeiro parâmetro a verificar é o consumo de energia.

Você precisa usar os números binários no relatório de diagnóstico para gerar dois novos números binários (chamados de taxa gama e taxa épsilon ). O consumo de energia pode então ser encontrado multiplicando a taxa gama pela taxa épsilon.

Cada bit na taxa gama pode ser determinado encontrando o bit mais comum na posição correspondente de todos os números no relatório de diagnóstico. Por exemplo, dado o seguinte relatório de diagnóstico:

00100\
00100\
11110\
00100\
10110\
10111\
10101\
01111\
00111\
11100\
10000\
11001\
00010\
01010

Considerando apenas o primeiro bit de cada número, existem cinco 0 bits e sete 1 bits. Como o bit mais comum é 1, o primeiro bit da taxa gama é 1.

O segundo bit mais comum dos números no relatório de diagnóstico é 0, portanto, o segundo bit da taxa gama é 0.

O valor mais comum dos terceiro, quarto e quinto bits são 1, 1, e 0, respectivamente, e de modo que os três últimos bits da taxa gama são 110.

Portanto, a taxa gama é o número binário 10110, ou 22decimal.

A taxa épsilon é calculada de maneira semelhante; em vez de usar o bit mais comum, é usado o bit menos comum de cada posição. Portanto, a taxa épsilon é 01001, ou 9em decimal. Multiplicar a taxa gama ( 22) pela taxa épsilon ( 9) produz o consumo de energia 198,.

Use os números binários em seu relatório de diagnóstico para calcular a taxa gama e a taxa épsilon e, em seguida, multiplique-os. Qual é o consumo de energia do submarino? (Certifique-se de representar sua resposta em decimal, não binário.)

Para começar, obtenha informações sobre o quebra-cabeça. (path: Dados/relatorio-de-diagnostico.txt)


#### Parte dois

Em seguida, você deve verificar a classificação de suporte de vida , que pode ser determinada multiplicando a classificação do gerador de oxigênio pela classificação do purificador de CO2.

Tanto a classificação do gerador de oxigênio quanto a classificação do purificador de CO2 são valores que podem ser encontrados em seu relatório de diagnóstico - encontrá-los é a parte complicada. Ambos os valores são localizados usando um processo semelhante que envolve a filtragem de valores até que apenas um permaneça. Antes de pesquisar qualquer valor de classificação, comece com a lista completa de números binários de seu relatório de diagnóstico e considere apenas o primeiro bit desses números. Então:

- Mantenha apenas os números selecionados pelos critérios de bits para o tipo de valor de classificação que você está procurando. Descarte os números que não correspondem aos critérios de bit.

- Se você só tem um número restante, pare; este é o valor de classificação que você está procurando.

- Caso contrário, repita o processo, considerando o próximo bit à direita.

Os critérios de bits dependem de qual tipo de valor de classificação você deseja encontrar:

- Para encontrar a classificação do gerador de oxigênio, determine o valor mais comum ( 0 ou 1) na posição do bit atual e mantenha apenas os números com esse bit nessa posição. Se 0 e 1 forem igualmente comuns, mantenha os valores com a 1 na posição que está sendo considerada.

- Para encontrar a classificação do purificador de CO2 , determine o menor valor comum ( 0 ou 1) na posição do bit atual e mantenha apenas os números com esse bit nessa posição. Se 0 e 1 forem igualmente comuns, mantenha os valores com a 0 na posição que está sendo considerada.

Por exemplo, para determinar o valor da classificação do gerador de oxigênio usando o mesmo relatório de diagnóstico de exemplo acima:

- Comece com todos os 12 números e considere apenas o primeiro bit de cada número. Há mais 1bits (7) do que 0pedaços (5), de modo a manter apenas os números 7, com um 1 na primeira posição: 11110, 10110, 10111, 10101, 11100, 10000, e 11001.

- Em seguida, considerar o segundo bit de os 7 restantes números: existem mais 0 bits (4) do que 1pedaços (3), de modo a manter apenas os números 4, com um 0 na segunda posição: 10110, 10111, 10101, e 10000.

- Na terceira posição, três dos quatro números têm um 1, de modo a manter os três: 10110, 10111, e 10101.

- Na quarta posição, dois dos três números têm um 1, então mantenha esses dois: 10110e 10111.

- Na quinta posição, há um número igual de 0 bits e 1 bits (um para cada). Assim, para encontrar a classificação gerador de oxigênio, manter o número com um 1 nessa posição: 10111.

- Como só resta um número, pare; a classificação do gerador de oxigênio é 10111, ou 23 em decimal.

Então, para determinar o valor de classificação do purificador de CO2 do mesmo exemplo acima:

- Comece novamente com todos os 12 números e considere apenas o primeiro bit de cada número. Há menos 0bits (5) do que 1os bits (7), de modo a manter apenas os números 5, com um 0na primeira posição: 00100, 01111, 00111, 00010, e 01010.

- Então, considere o segundo bit dos 5 números restantes: há menos 1bits (2) do que 0bits (3), portanto, mantenha apenas os 2 números com a 1na segunda posição: 01111 e 01010.

- Na terceira posição, há um número igual de 0bits e 1bits (um para cada). Assim, para encontrar a classificação purificador de CO2 , manter o número com um 0nessa posição: 01010.

- Como só resta um número, pare; a classificação do purificador de CO2 é 01010, ou 10 em decimal.

Finalmente, para encontrar a classificação de suporte de vida, multiplique a classificação do gerador de oxigênio (23) pela classificação do purificador de CO2 (10) para obter 230.

Use os números binários em seu relatório de diagnóstico para calcular a classificação do gerador de oxigênio e a classificação do purificador de CO2 e, em seguida, multiplique-os. Qual é a classificação de suporte de vida do submarino? (Certifique-se de representar sua resposta em decimal, não binário.)

Embora não tenha mudado, você ainda pode obter informações sobre o quebra-cabeça. (path: Dados/relatorio-de-diagnostico.txt)
