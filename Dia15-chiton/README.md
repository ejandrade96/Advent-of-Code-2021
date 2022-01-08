### Dia 15: Chiton

Você quase alcançou a saída da caverna, mas as paredes estão se aproximando. Porém, seu submarino mal cabe; o principal problema é que as paredes da caverna estão cobertas de **quitônios** e é melhor não esbarrar em nenhum deles.

A caverna é grande, mas tem um teto muito baixo, restringindo seu movimento a duas dimensões. A forma da caverna lembra um quadrado; uma varredura rápida da densidade do quitão produz um mapa do **nível de risco** em toda a caverna (sua entrada no quebra-cabeça). Por exemplo:

image

Você começa na posição superior esquerda, seu destino é a posição inferior direita e você não pode se mover na diagonal. O número em cada posição é seu **nível de risco**; para determinar o risco total de um caminho inteiro, some os níveis de risco de cada posição que você **inserir** (ou seja, não conte o nível de risco de sua posição inicial a menos que você o insira; deixá-lo não adiciona nenhum risco ao seu total).

Seu objetivo é encontrar um caminho com o **menor risco total**. Neste exemplo, um caminho com o menor risco total é destacado aqui:

image

O risco total desse caminho é **40** (a posição inicial nunca é inserida, portanto, seu risco não é contado).

**Qual é o menor risco total de qualquer caminho do canto superior esquerdo ao canto inferior direito?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/input.txt)