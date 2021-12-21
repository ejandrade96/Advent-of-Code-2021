### Dia 11: Dumbo Octopus

Você entra em uma grande caverna cheia de raros **polvos dumbo** bioluminescentes! Eles parecem não gostar das luzes de Natal do seu submarino, então você as desliga por enquanto.

Existem 100 polvos dispostos ordenadamente em uma grade de 10 por 10. Cada polvo lentamente ganha **energia** com o tempo e **pisca** intensamente por um momento quando sua energia está cheia. Embora suas luzes estejam apagadas, talvez você pudesse navegar pela caverna sem perturbar os polvos se pudesse prever quando os flashes de luz acontecerão.

Cada polvo tem um **nível de energia** - seu submarino pode medir remotamente o nível de energia de cada polvo (sua entrada no quebra-cabeça). Por exemplo:

IMAGE

O nível de energia de cada polvo é um valor entre **0** e **9**. Aqui, o polvo superior esquerdo tem um nível de energia de **5**, o polvo inferior direito tem um nível de energia de **6** e assim por diante.

Você pode modelar os níveis de energia e flashes de luz em **etapas**. Durante uma única etapa, ocorre o seguinte:

- Primeiro, o nível de energia de cada polvo aumenta **1**.

- Então, qualquer polvo com um nível de energia maior do que **9 pisca**. Isso aumenta o nível de energia de todos os polvos adjacentes em **1**, incluindo os polvos que são diagonalmente adjacentes. Se isso fizer com que um polvo tenha um nível de energia maior que **9**, ele **também piscará**. Este processo continua enquanto novos polvos continuam tendo seu nível de energia aumentado **9**. (Um polvo só pode piscar **no máximo uma vez por passo**.)

- Por fim, qualquer polvo que brilhou durante esta etapa tem seu nível de energia definido **0** como, pois usou toda a sua energia para piscar.

Flashes adjacentes podem fazer com que um polvo pisque em um degrau, mesmo que comece aquele degrau com muito pouca energia. Considere o polvo do meio com **1** energia nesta situação:

IMAGE

Um polvo é **destacado** quando piscou durante a etapa dada.

Aqui está como o exemplo maior acima progride:

IMAGE 3 a 8

Após a etapa 10, houve um total de **204** flashes. Avançando, aqui está a mesma configuração a cada 10 etapas:

IMAGE 9 a 13

Após 100 etapas, houve um total de **1656** flashes.

Dados os níveis de energia iniciais dos polvos dumbo em sua caverna, simule 100 passos. **Quantos flashes no total existem após 100 etapas?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/niveis-energia-polvos.txt)