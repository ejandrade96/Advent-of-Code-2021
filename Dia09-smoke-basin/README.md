### Dia 9: Smoke Basin

Essas cavernas parecem **tubos de lava**. Algumas partes ainda estão vulcanicamente ativas; pequenas fontes hidrotermais liberam fumaça nas cavernas, que lentamente se acomoda como chuva.

Se você puder modelar como a fumaça flui pelas cavernas, poderá evitá-la e ficar muito mais seguro. O submarino gera um mapa de altura do piso das cavernas próximas para você (sua entrada no quebra-cabeça).

A fumaça flui para o ponto mais baixo da área em que está. Por exemplo, considere o seguinte mapa de altura:

IMAGE

Cada número corresponde à altura de um local específico, onde **9** é o mais alto e **0** é o mais baixo que um local pode ser.

Seu primeiro objetivo é encontrar os **pontos baixos** - os locais que são mais baixos do que qualquer um de seus locais adjacentes. A maioria dos locais possui quatro locais adjacentes (cima, baixo, esquerda e direita); os locais na borda ou no canto do mapa têm três ou dois locais adjacentes, respectivamente. (Localizações diagonais não contam como adjacentes).

No exemplo acima, existem **quatro** pontos baixos, todos destacados: dois estão na primeira linha (a **1** e a **0**), um está na terceira linha (a **5**) e um está na linha inferior (também a **5**). Todos os outros locais no mapa de altura têm algum local adjacente inferior e, portanto, não são pontos baixos.

O **nível de risco** de um ponto baixo é **1 mais sua altura**. No exemplo acima, os níveis de risco dos pontos mais baixos são **2**, **1**, **6**, e **6**. A soma dos níveis de risco de todos os pontos baixos no mapa de altura é, portanto **15**.

Encontre todos os pontos baixos em seu mapa de altura. **Qual é a soma dos níveis de risco de todos os pontos baixos em seu mapa de altura?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/input.txt)

