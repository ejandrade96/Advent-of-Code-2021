
### Dia 4: Lula gigante

Você já está quase 1,5 km (quase uma milha) abaixo da superfície do oceano, já tão profundo que não consegue ver a luz do sol. O que você **pode** ver, entretanto, é uma lula gigante que se fixou na parte externa do seu submarino.

Talvez queira jogar **bingo**?

O bingo é jogado em um conjunto de tabuleiros, cada um consistindo de uma grade 5x5 de números. Os números são escolhidos aleatoriamente e o número escolhido é **marcado** em todos os tabuleiros em que aparece. (Os números podem não aparecer em todos os tabuleiros.) Se todos os números em qualquer linha ou coluna de um tabuleiro forem marcados, esse tabuleiro **ganha**. (Diagonais não contam.)

O submarino possui um **subsistema de bingo** para ajudar os passageiros (atualmente, você e a lula gigante) a passar o tempo. Ele gera automaticamente uma ordem aleatória para desenhar números e um conjunto aleatório de placas (sua entrada de quebra-cabeça). Por exemplo:

![Captura de tela de 2021-12-13 20-08-35](https://user-images.githubusercontent.com/57911863/145903496-2165decb-0052-4af2-8212-7c7d505e3180.png)
 
Após os cinco primeiros números são extraídos (7, 4, 9, 5, e 11), não há vencedores, mas as placas são marcadas como se segue (aqui mostrado adjacentes uns aos outros para poupar espaço):
 
![print1](https://user-images.githubusercontent.com/57911863/145903651-d1caef8a-7094-4fa2-83ec-a62bf6ba34a7.png)

Depois dos próximos seis números são extraídos (**17, 23, 2, 0, 14, e 21**), não há ainda nenhum vencedores:
 
![print2](https://user-images.githubusercontent.com/57911863/145903656-9d398121-743e-4032-b4a1-1a68bb3d4357.png)
 
Finalmente, **24** é desenhado:

![print3](https://user-images.githubusercontent.com/57911863/145903659-8bcd4277-6a31-496c-80d8-ff75e2bc4498.png)
 
Neste ponto, o terceiro tabuleiro **vence** porque tem pelo menos uma linha ou coluna completa de números marcados (neste caso, toda a linha superior é marcada:) 14 21 17 24 4.

A **pontuação** da mesa vencedora agora pode ser calculada. Comece encontrando a **soma de todos os números não marcados** naquele tabuleiro; neste caso, a soma é 188. Em seguida, multiplique essa soma pelo **número que acabou de ser chamado** quando o tabuleiro venceu,, 24 para obter a pontuação final,. **188 * 24 = 4512**

Para garantir a vitória contra a lula gigante, descubra qual tabuleiro vencerá primeiro. **Qual será a sua pontuação final se você escolher esse tabuleiro?**
 
Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/informacoes-bingo.txt)


#### Parte 2

Por outro lado, pode ser sensato tentar uma estratégia diferente: deixar a lula gigante vencer.

Você não tem certeza de quantos tabuleiros de bingo uma lula gigante pode jogar de uma vez, então, em vez de perder tempo contando seus braços, a coisa segura a fazer é **descobrir qual tabuleiro vencerá por último** e escolher aquele. Dessa forma, não importa quais pranchas ela escolha, ela vencerá com certeza.

No exemplo acima, o segundo tabuleiro é o último a vencer, o que acontece depois de 13ser eventualmente chamado e sua coluna do meio está completamente marcada. Se você continuasse jogando até este ponto, o segundo tabuleiro teria uma soma de números não marcados igual a 148para uma pontuação final de. **148 * 13 = 1924**

Descubra qual tabuleiro vencerá por último. **Depois de vencer, qual seria sua pontuação final?**

Embora não tenha mudado, você ainda pode **obter informações sobre o quebra-cabeça**. (path: Dados/informacoes-bingo.txt)
