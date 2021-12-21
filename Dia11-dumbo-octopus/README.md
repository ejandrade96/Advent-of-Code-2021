### Dia 11: Dumbo Octopus

Você entra em uma grande caverna cheia de raros **polvos dumbo** bioluminescentes! Eles parecem não gostar das luzes de Natal do seu submarino, então você as desliga por enquanto.

Existem 100 polvos dispostos ordenadamente em uma grade de 10 por 10. Cada polvo lentamente ganha **energia** com o tempo e **pisca** intensamente por um momento quando sua energia está cheia. Embora suas luzes estejam apagadas, talvez você pudesse navegar pela caverna sem perturbar os polvos se pudesse prever quando os flashes de luz acontecerão.

Cada polvo tem um **nível de energia** - seu submarino pode medir remotamente o nível de energia de cada polvo (sua entrada no quebra-cabeça). Por exemplo:

![1](https://user-images.githubusercontent.com/57911863/146992930-e8285ec7-7eb1-4810-8e78-fdd7b5f659a9.png)

O nível de energia de cada polvo é um valor entre **0** e **9**. Aqui, o polvo superior esquerdo tem um nível de energia de **5**, o polvo inferior direito tem um nível de energia de **6** e assim por diante.

Você pode modelar os níveis de energia e flashes de luz em **etapas**. Durante uma única etapa, ocorre o seguinte:

- Primeiro, o nível de energia de cada polvo aumenta **1**.
- Então, qualquer polvo com um nível de energia maior do que **9 pisca**. Isso aumenta o nível de energia de todos os polvos adjacentes em **1**, incluindo os polvos que são diagonalmente adjacentes. Se isso fizer com que um polvo tenha um nível de energia maior que **9**, ele **também piscará**. Este processo continua enquanto novos polvos continuam tendo seu nível de energia aumentado **9**. (Um polvo só pode piscar **no máximo uma vez por passo**.)
- Por fim, qualquer polvo que brilhou durante esta etapa tem seu nível de energia definido **0** como, pois usou toda a sua energia para piscar.

Flashes adjacentes podem fazer com que um polvo pisque em um degrau, mesmo que comece aquele degrau com muito pouca energia. Considere o polvo do meio com **1** energia nesta situação:

![2](https://user-images.githubusercontent.com/57911863/146992939-f17149d1-cde9-4063-b060-0a6c1ae1bfc5.png)

Um polvo é **destacado** quando piscou durante a etapa dada.

Aqui está como o exemplo maior acima progride:

![3](https://user-images.githubusercontent.com/57911863/146992950-1036381d-64a7-4b4b-8aae-1f4653d9e661.png)  
![4](https://user-images.githubusercontent.com/57911863/146992954-2c1651f5-d6aa-48d1-bc47-e91b17f26e06.png)  
![5](https://user-images.githubusercontent.com/57911863/146992959-d3d21785-3491-45cc-80df-9be242d360de.png)  
![6](https://user-images.githubusercontent.com/57911863/146992969-d0721381-72ad-4846-94cb-bcf7e92e9fbb.png)  
![7](https://user-images.githubusercontent.com/57911863/146992975-823ed2cb-98d2-464b-b822-b9410d71c99d.png)  
![8](https://user-images.githubusercontent.com/57911863/146992979-de3b0ea1-68ac-463e-a5ff-f1470073ab78.png)

Após a etapa 10, houve um total de **204** flashes. Avançando, aqui está a mesma configuração a cada 10 etapas:

![9](https://user-images.githubusercontent.com/57911863/146992991-5e5197f7-b667-4e75-b5da-611b7b9939a3.png)  
![10](https://user-images.githubusercontent.com/57911863/146992993-71e61db7-7fbd-494a-9bec-9ac5791d1006.png)  
![11](https://user-images.githubusercontent.com/57911863/146992994-aba8477f-99fa-495b-ae9c-57005e691ccb.png)  
![12](https://user-images.githubusercontent.com/57911863/146992996-bab7f52d-3dc3-49fb-97b1-69c783542fb8.png)  
![13](https://user-images.githubusercontent.com/57911863/146992999-242086eb-063c-430d-95a7-afc0163331a9.png)

Após 100 etapas, houve um total de **1656** flashes.

Dados os níveis de energia iniciais dos polvos dumbo em sua caverna, simule 100 passos. **Quantos flashes no total existem após 100 etapas?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/niveis-energia-polvos.txt)
