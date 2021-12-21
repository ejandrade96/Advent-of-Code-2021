### Dia 12: Trajeto de passagem

Com os subsistemas subterrâneos do seu submarino subsistindo de forma subótima, a única maneira de sair desta caverna em breve é encontrando um caminho sozinho. Não apenas **um** caminho - a única maneira de saber se você encontrou o **melhor** caminho é encontrando **todos** eles.

Felizmente, a maioria dos sensores ainda está funcionando, então você constrói um mapa aproximado das cavernas restantes (sua entrada no quebra-cabeça). Por exemplo:

![1](https://user-images.githubusercontent.com/57911863/146995216-6647d64e-c5c4-4956-a7f1-2b5544320a22.png)

Esta é uma lista de como todas as cavernas estão conectadas. Você começa na caverna nomeada **start** e seu destino é a caverna nomeada **end**. Uma entrada como **b-d** significa que a caverna **b** está conectada à caverna **d** - ou seja, você pode mover-se entre elas.

Então, o sistema de cavernas acima é mais ou menos assim:

![2](https://user-images.githubusercontent.com/57911863/146995228-a11c68bd-51c9-42fc-9029-f5eac3f4cc80.png)

Seu objetivo é encontrar o número de **caminhos** distintos que começam **start**, terminam **end** e não visitam pequenas cavernas mais de uma vez. Existem dois tipos de cavernas: **grandes** cavernas (escritas em letras maiúsculas, como **A**) e **pequenas** cavernas (escritas em letras minúsculas, como **b**). Seria uma perda de tempo visitar qualquer caverna pequena mais de uma vez, mas cavernas grandes são grandes o suficiente para que valha a pena visitá-las várias vezes. Portanto, todos os caminhos que você encontrar devem **visitar pequenas cavernas no máximo uma vez**, e podem **visitar grandes cavernas quantas vezes forem**.

Dadas essas regras, existem **10** caminhos por meio deste sistema de cavernas de exemplo:

![3](https://user-images.githubusercontent.com/57911863/146995249-e1c4fdff-2fd2-42cc-ac21-c695a4d06f96.png)

(Cada linha na lista acima corresponde a um único caminho; as cavernas visitadas por esse caminho são listadas na ordem em que são visitadas e separadas por vírgulas.)

Observe que neste sistema de cavernas, a caverna **d** nunca é visitada por nenhum caminho: para fazer isso, a caverna **b** precisaria ser visitada duas vezes (uma vez no caminho para a caverna **d** e uma segunda vez ao retornar da caverna **d**), e como a caverna **b** é pequena, esta não é permitido.

Aqui está um exemplo um pouco maior:

![4](https://user-images.githubusercontent.com/57911863/146995259-9efc1616-147d-4ac3-ba34-988e4c6abdf4.png)

Os **19** caminhos são os seguintes:

![5](https://user-images.githubusercontent.com/57911863/146995278-907607eb-2198-4f9c-87ed-5bc9e7633b65.png)

Finalmente, este exemplo ainda maior tem **226** caminhos através dele:

![6](https://user-images.githubusercontent.com/57911863/146995285-592e854a-5a88-4673-9b2d-4f1e6b12c7c4.png)

**Quantos caminhos neste sistema de cavernas existem que visitam pequenas cavernas no máximo uma vez?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/mapa-cavernas-restantes.txt)
