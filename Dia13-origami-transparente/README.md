### Dia 13: Origami transparente

Você alcança outra parte da caverna com atividade vulcânica. Seria bom se você pudesse fazer algum tipo de imagem térmica para saber com antecedência quais cavernas estão muito quentes para entrar com segurança.

Felizmente, o submarino parece estar equipado com uma câmera térmica! Ao ativá-lo, você será saudado com:

**Parabéns pela sua compra! Para ativar esta imagem térmica infravermelha sistema de câmera, digite o código encontrado na página 1 do manual**

Aparentemente, os elfos nunca usaram esse recurso. Para sua surpresa, você conseguiu encontrar o manual; conforme você abre, a página 1 cai. É uma grande folha de **papel transparente**! O papel transparente é marcado com pontos aleatórios e inclui instruções sobre como dobrá-lo (sua entrada no quebra-cabeça). Por exemplo:

![1](https://user-images.githubusercontent.com/57911863/148648618-44fda5ec-e383-4717-8223-5a310b62df6b.png)

A primeira seção é uma lista de pontos no papel transparente. **0,0** representa a coordenada superior esquerda. O primeiro valor, **x**, aumenta para a direita. O segundo valor, **y**, aumenta para baixo. Então, a coordenada **3,0** está à direita de **0,0**, e a coordenada **0,7** está abaixo **0,0**. As coordenadas neste exemplo formam o seguinte padrão, onde **#** é um ponto no papel e **.** é uma posição vazia e não marcada:

![2](https://user-images.githubusercontent.com/57911863/148648620-5053eda9-7ca2-4d72-9fef-5b8c45bfb2df.png)

Em seguida, há uma lista de **instruções dobráveis**. Cada instrução indica uma linha no papel transparente e quer que você dobre o papel para **cima** (para **y=...** linhas horizontais) ou para a **esquerda** (para **x=...** linhas verticais). Neste exemplo, a primeira instrução de dobra é **fold along y=7**, que designa a linha formada por todas as posições onde **y** está **7** (marcada aqui com **-**):

![3](https://user-images.githubusercontent.com/57911863/148648624-5a722fd0-98eb-43a7-9da7-bc01ee4a71f7.png)

Como esta é uma linha horizontal, dobre a metade inferior para **cima**. Alguns dos pontos podem acabar se sobrepondo após a dobra ser concluída, mas os pontos nunca aparecerão exatamente em uma linha de dobra. O resultado dessa dobra é o seguinte:

![4](https://user-images.githubusercontent.com/57911863/148648630-cbfbe7c1-a169-4283-8d80-524694f6656c.png)

Agora, apenas os **17** pontos são visíveis.

Observe, por exemplo, os dois pontos no canto esquerdo inferior antes que o papel transparente seja dobrado; depois de concluída a dobra, esses pontos aparecem no canto superior esquerdo (em **0,0** e **0,1**). Como o papel é transparente, o ponto logo abaixo deles no resultado (at **0,3**) permanece visível, como pode ser visto através do papel transparente.

Observe também que alguns pontos podem acabar se **sobrepondo**; neste caso, os pontos se fundem e se tornam um único ponto.

A segunda instrução dobra é **fold along x=5**, que indica esta linha:

![5](https://user-images.githubusercontent.com/57911863/148648635-f18f1b37-7ffc-432a-96d1-eecfa5e150d6.png)

Como esta é uma linha vertical, dobre para a **esquerda**:

![6](https://user-images.githubusercontent.com/57911863/148648636-a648cd2b-1226-44c7-924d-bb4354e1dacf.png)

As instruções formaram um quadrado!

O papel transparente é muito grande, então, por enquanto, concentre-se apenas em completar a primeira dobra. Após a primeira dobra no exemplo acima, os **17** pontos ficam visíveis - os pontos que acabam se sobrepondo após a dobra ser concluída contam como um único ponto.

**Quantos pontos ficam visíveis depois de concluir apenas a instrução da primeira dobra em seu papel transparente?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/instrucoes.txt)
