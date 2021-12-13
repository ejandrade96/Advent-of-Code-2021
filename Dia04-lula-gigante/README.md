
### Dia 4: Lula gigante

Você já está quase 1,5 km (quase uma milha) abaixo da superfície do oceano, já tão profundo que não consegue ver a luz do sol. O que você **pode** ver, entretanto, é uma lula gigante que se fixou na parte externa do seu submarino.

Talvez queira jogar bingo?

O bingo é jogado em um conjunto de tabuleiros, cada um consistindo de uma grade 5x5 de números. Os números são escolhidos aleatoriamente e o número escolhido é **marcado** em todos os tabuleiros em que aparece. (Os números podem não aparecer em todos os tabuleiros.) Se todos os números em qualquer linha ou coluna de um tabuleiro forem marcados, esse tabuleiro **ganha**. (Diagonais não contam.)

O submarino possui um **subsistema de bingo** para ajudar os passageiros (atualmente, você e a lula gigante) a passar o tempo. Ele gera automaticamente uma ordem aleatória para desenhar números e um conjunto aleatório de placas (sua entrada de quebra-cabeça). Por exemplo:

7,4,9,5,11,17,23,2,0,14,21,24,10,16,13,6,15,25,12,22,18,20,8,19,3,26,1

22 13 17 11  0
 8  2 23  4 24
21  9 14 16  7
 6 10  3 18  5
 1 12 20 15 19

 3 15  0  2 22
 9 18 13 17  5
19  8  7 25 23
20 11 10 24  4
14 21 16 12  6

14 21 17 24  4
10 16 15  9 19
18  8 23 26 20
22 11 13  6  5
 2  0 12  3  7
 
Após os cinco primeiros números são extraídos (7, 4, 9, 5, e 11), não há vencedores, mas as placas são marcadas como se segue (aqui mostrado adjacentes uns aos outros para poupar espaço):
 
22 13 17 **11**  0         3 15  0  2 22        14 21 17 24  **4**
 8  2 23  **4** 24         **9** 18 13 17  **5**        10 16 15  **9** 19
21  **9** 14 16  **7**        19  8  **7** 25 23        18  8 23 26 20
 6 10  3 18  **5**        20 **11** 10 24  **4**        22 **11** 13  6  **5**
 1 12 20 15 19        14 21 16 12  6         2  0 12  3  **7**
 
Depois dos próximos seis números são extraídos (17, 23, 2, 0, 14, e 21), não há ainda nenhum vencedores:
 
22 13 **17 11  0**         3 15  **0  2** 22        **14 21 17** 24 **4**
 8  **2 23  4** 24         **9** 18 13 **17**  5        10 16 15  **9** 19
**21  9 14** 16  **7**        19  8  **7** 25 **23**        18  8 **23** 26 20
 6 10  3 18  **5**        20 **11** 10 24 **4**        22 **11** 13  6  **5**
 1 12 20 15 19        **14 21** 16 12  6         **2  0** 12  3  **7**
 
Finalmente, 24 é desenhado:

22 13 **17 11  0**         3 15  **0  2** 22        **14 21 17 24 4**
 8  **2 23  4 24**         **9** 18 13 **17**  5        10 16 15  **9** 19
**21  9 14** 16  **7**        19  8  **7** 25 **23**        18  8 **23** 26 20
 6 10  3 18  **5**        20 **11** 10 **24 4**        22 **11** 13  6  **5**
 1 12 20 15 19        **14 21** 16 12  6         **2  0** 12  3  **7**
 
Neste ponto, o terceiro tabuleiro **vence** porque tem pelo menos uma linha ou coluna completa de números marcados (neste caso, toda a linha superior é marcada:) 14 21 17 24 4.

A **pontuação** da mesa vencedora agora pode ser calculada. Comece encontrando a **soma de todos os números não marcados** naquele tabuleiro; neste caso, a soma é 188. Em seguida, multiplique essa soma pelo **número que acabou de ser chamado** quando o tabuleiro venceu,, 24 para obter a pontuação final,. 188 * 24 = 4512

Para garantir a vitória contra a lula gigante, descubra qual tabuleiro vencerá primeiro. **Qual será a sua pontuação final se você escolher esse tabuleiro?**
 
Para começar, obtenha informações sobre o quebra-cabeça. (path: Dados/informacoes-bingo.txt)
