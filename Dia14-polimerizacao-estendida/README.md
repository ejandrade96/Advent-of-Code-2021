### Dia 14: Polimerização Estendida

As incríveis pressões a essa profundidade estão começando a sobrecarregar o seu submarino. O submarino tem equipamento de **polimerização** que produziria materiais adequados para reforçar o submarino, e as cavernas vulcanicamente ativas próximas devem ter os elementos de entrada necessários em quantidades suficientes.

O manual do submarino contém instruções para encontrar a fórmula de polímero ideal; especificamente, ele oferece um **modelo de polímero** e uma lista de regras de **inserção** de **pares** (sua entrada de quebra-cabeça). Você só precisa descobrir qual polímero resultaria após repetir o processo de inserção do par algumas vezes.

Por exemplo:

![1](https://user-images.githubusercontent.com/57911863/148649359-94302fe9-a6aa-416b-a1a2-2b909c43a269.png)

A primeira linha é o **modelo de polímero** - este é o ponto de partida do processo.

A seção a seguir define as regras de **inserção de pares**. Uma regra como **AB -> C** significa que quando os elementos **A** e **B** são imediatamente adjacentes, o elemento **C** deve ser inserido entre eles. Todas essas inserções acontecem simultaneamente.

Portanto, começando com o modelo de polímero **NNCB**, a primeira etapa considera simultaneamente todos os três pares:

- O primeiro par (**NN**) corresponde à regra **NN -> C**, portanto, o elemento **C** é inserido entre o primeiro **N** e o segundo **N**.

- O segundo par (**NC**) corresponde à regra **NC -> B**, portanto, o elemento **B** é inserido entre o **N** e o **C**.

- O terceiro par (**CB**) corresponde à regra **CB -> H**, portanto, o elemento **H** é inserido entre o **C** e o **B**.

Observe que esses pares se sobrepõem: o segundo elemento de um par é o primeiro elemento do próximo par. Além disso, como todos os pares são considerados simultaneamente, os elementos inseridos não são considerados parte de um par até a próxima etapa.

Após a primeira etapa deste processo, o polímero torna-se **NCNBCHB**.

Aqui estão os resultados de algumas etapas usando as regras acima:

![2](https://user-images.githubusercontent.com/57911863/148649360-f1d93522-5185-401f-a47e-fb6056556bef.png)

Este polímero cresce rapidamente. Após a etapa 5, ele tem comprimento 97; Após a etapa 10, ele tem comprimento 3073. Após a etapa 10, **B** ocorre 1749 vezes, **C** ocorre 298 vezes, **H** ocorre 161 vezes e **N** ocorre 865 vezes; tomando a quantidade do elemento mais comum (**B**, 1749) e subtraindo a quantidade do elemento menos comum (**H**, 161) produz **1749 - 161 = 1588**.

Aplique 10 etapas de inserção de pares ao modelo de polímero e encontre os elementos mais e menos comuns no resultado. **O que você ganha se pegar a quantidade do elemento mais comum e subtrair a quantidade do elemento menos comum?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/input.txt)
