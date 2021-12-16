### Dia 5: Empreendimento hidrotérmico

Você se depara com um campo de **fontes hidrotermais** no fundo do oceano! Essas aberturas produzem constantemente nuvens grandes e opacas, portanto, é melhor evitá-las, se possível.

Eles tendem a se formar em **linhas**; o submarino produz uma lista de linhas de aberturas próximas (sua entrada no quebra-cabeça) para você revisar. Por exemplo:

IMAGE

Cada linha de aberturas é dada como um segmento de linha no formato de **x1,y1 -> x2,y2** onde **x1,y1** são as coordenadas de uma extremidade do segmento de linha e x2, y2são as coordenadas da outra extremidade. Esses segmentos de linha incluem os pontos em ambas as extremidades. Em outras palavras:

- Uma entrada como **1,1 -> 1,3** pontos tampas **1,1, 1,2, e 1,3**.

- Uma entrada como **9,7 -> 7,7** pontos tampas **9,7, 8,7, e 7,7**.

Por enquanto, **considere apenas as linhas horizontais e verticais**: linhas onde ou **x1 = x2** ou **y1 = y2**.

Portanto, as linhas horizontais e verticais da lista acima produziriam o seguinte diagrama:

IMAGE

Neste diagrama, o canto superior esquerdo é **0,0** e o canto inferior direito é **9,9**. Cada posição é mostrada como **o número de linhas que cobrem aquele ponto** ou **.** se nenhuma linha cobrir esse ponto. O par superior esquerdo de **1**s, por exemplo, vem de **2,2 -> 2,1**; a linha inferior é formada pelas linhas sobrepostas **0,9 -> 5,9** e **0,9 -> 2,9**.

Para evitar as áreas mais perigosas, você precisa determinar **o número de pontos onde pelo menos duas linhas se sobrepõem**. No exemplo acima, isso está em qualquer lugar no diagrama com a **2** ou maior - um total de **5** pontos.

Considere apenas linhas horizontais e verticais. **Em quantos pontos pelo menos duas linhas se sobrepõem?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/.txt)
