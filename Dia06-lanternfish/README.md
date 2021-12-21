### Dia 6 Lanternfish

O fundo do mar está ficando mais íngreme. Talvez as chaves do trenó tenham sido carregadas desta forma?

Um enorme cardume de **peixes-lanterna** brilhantes passa nadando. Eles devem se reproduzir rapidamente para atingir um número tão grande - talvez **exponencialmente** rapidamente? Você deve modelar sua taxa de crescimento para ter certeza.

Embora você não saiba nada sobre essa espécie específica de peixe-lanterna, você faz algumas suposições sobre seus atributos. Certamente, cada peixe-lanterna cria um novo peixe-lanterna uma vez a cada **7** dias.

No entanto, este processo não é necessariamente sincronizado entre cada peixe-lanterna - um peixe-lanterna pode ter 2 dias restantes até criar outro peixe-lanterna, enquanto outro pode ter 4. Portanto, você pode modelar cada peixe como um único número que representa **o número de dias até ele cria um novo peixe-lanterna**.

Além disso, você raciocina, um novo peixe-lanterna certamente precisaria de um pouco mais de tempo antes de ser capaz de produzir mais peixe-lanterna: mais dois dias para seu primeiro ciclo.

Então, suponha que você tenha um peixe-lanterna com um valor de temporizador interno de **3**:

- Depois de um dia, seu cronômetro interno se transformaria **2**.

- Depois de outro dia, seu cronômetro interno se transformaria **1**.

- Depois de outro dia, seu cronômetro interno se transformaria **0**.

- Depois de outro dia, seu cronômetro interno seria zerado **6** e ele criaria um **novo** peixe-lanterna com um cronômetro interno de **8**.

- Depois de outro dia, o primeiro peixe-lanterna teria um cronômetro interno de **5** e o segundo peixe-lanterna teria um cronômetro interno de **7**.

Um peixe-lanterna que cria um novo peixe zera seu cronômetro para **6**, **não 7** (porque **0** está incluído como um valor de cronômetro válido). O novo peixe-lanterna começa com um cronômetro interno de **8** e não começa a contagem regressiva até o dia seguinte.

Percebendo o que você está tentando fazer, o submarino produz automaticamente uma lista das idades de várias centenas de peixes-lanterna próximos (sua entrada no quebra-cabeça). Por exemplo, suponha que você tenha recebido a seguinte lista:

**3,4,3,1,2**

Esta lista significa que o primeiro peixe tem um cronômetro interno de 3, o segundo peixe tem um cronômetro interno de 4e assim por diante até o quinto peixe, que tem um cronômetro interno de 2. Simular esses peixes ao longo de vários dias seria o seguinte:

IMAGE

A cada dia, a **0** torna - se um **6** e adiciona um novo **8** ao final da lista, enquanto cada número diminui em **1** se estiver presente no início do dia.

Neste exemplo, após 18 dias, há um total de **26** peixes. Após 80 dias, haveria um total de **5934**.

Encontre uma maneira de simular o peixe-lanterna. **Quantos peixes-lanterna haveria depois de 80 dias?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/idades-peixes-lanterna.txt)
