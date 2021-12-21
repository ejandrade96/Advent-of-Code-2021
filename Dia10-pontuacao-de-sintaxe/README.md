### Dia 10: Pontuação de sintaxe

Você pede ao submarino para determinar a melhor rota para sair da caverna no fundo do mar, mas ele apenas responde:

**Syntax error in navigation subsystem on line: all of them**

**Todos eles?!** O dano é pior do que você pensava. Você abre uma cópia do subsistema de navegação (sua entrada de quebra-cabeça).

A sintaxe do subsistema de navegação é composta por várias linhas contendo **blocos**. Há um ou mais blocos em cada linha e os blocos contêm zero ou mais blocos. Os pedaços adjacentes não são separados por nenhum delimitador; se um bloco parar, o próximo bloco (se houver) pode começar imediatamente. Cada pedaço deve **abrir** e **fechar** com um dos quatro pares legais de caracteres correspondentes:

IMAGE

Portanto, **()** é um bloco legal que não contém nenhum outro bloco, como está **[]**. Mais complexas, mas válidos pedaços incluem **([])**, **{()()()}**, **<([{}])>**, **[<>({}){}[([])<>]]**, e mesmo **(((((((((())))))))))**.

Algumas linhas estão **incompletas**, mas outras estão **corrompidas**. Encontre e descarte as linhas corrompidas primeiro.

Uma linha corrompida é aquela em que um bloco **fecha com o caractere errado** - ou seja, onde os caracteres com os quais ele abre e fecha não formam um dos quatro pares válidos listados acima.

Exemplos de pedaços corrompidas incluem **(]**, **{()()()>**, **(((()))}**, e **<([]){()}[{}])**. Esse pedaço pode aparecer em qualquer lugar dentro de uma linha e sua presença faz com que toda a linha seja considerada corrompida.

Por exemplo, considere o seguinte subsistema de navegação:

IMAGE

Algumas das linhas não estão corrompidas, apenas incompletas; você pode ignorar essas linhas por enquanto. As cinco linhas restantes estão corrompidas:

IMAGE

Pare no primeiro caractere de fechamento incorreto em cada linha corrompida.

Você sabia que os verificadores de sintaxe, na verdade, realizam concursos para ver quem consegue obter a pontuação mais alta para erros de sintaxe em um arquivo? É verdade! Para calcular a pontuação do erro de sintaxe para uma linha, pegue o **primeiro caractere ilegal** da linha e procure-o na tabela a seguir:

- **)**: **3** pontos.
- **]**: **57** pontos.
- **}**: **1197** pontos.
- **>**: **25137** pontos.

No exemplo acima, um ilegal **)** foi encontrado duas vezes (2 * 3 = 6 pontos), um ilegal **]** foi encontrado uma vez (**57** pontos), um ilegal **}** foi encontrado uma vez (**1197** pontos) e um ilegal **>** foi encontrado uma vez (**25137** pontos). Portanto, a pontuação total de erros de sintaxe para este arquivo é **6 + 57 + 1197 + 25137 = *26397*** pontos!

Encontre o primeiro caractere ilegal em cada linha corrompida do subsistema de navegação. **Qual é a pontuação total de erros de sintaxe para esses erros?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/subsistema-de-navegacao.txt)