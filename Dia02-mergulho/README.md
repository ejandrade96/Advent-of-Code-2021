### Dia 2: Mergulho!

Agora, você precisa descobrir como pilotar isso .

Parece que o submarino pode tomar uma série de comandos como forward 1, down 2ou up 3:

forward X aumenta a posição horizontal em X unidades.\
down X aumenta a profundidade em X unidades.\
up X diminui a profundidade em X unidades.\
Observe que, como você está em um submarino down e up afeta sua profundidade, eles têm o resultado oposto do que você esperava.

O submarino parece já ter um curso planejado (sua entrada no quebra-cabeça). Você provavelmente deve descobrir para onde está indo. Por exemplo:

forward 5\
down 5\
forward 8\
up 3\
down 8\
forward 2

Sua posição horizontal e profundidade começam em 0. As etapas acima os modificariam da seguinte maneira:

forward 5 adiciona 5 à sua posição horizontal um total de 5.\
down 5 adiciona 5 à sua profundidade, resultando em um valor de 5.\
forward 8 adiciona 8 à sua posição horizontal um total de 13.\
up 3 diminui sua profundidade em 3, resultando em um valor de 2.\
down 8 adiciona 8 à sua profundidade, resultando em um valor de 10.\
forward 2 adiciona 2 à sua posição horizontal um total de 15.\
Depois de seguir essas instruções, você teria uma posição horizontal de 15e uma profundidade de 10. (Multiplicando-os produz 150.)

Calcule a posição horizontal e a profundidade que você teria após seguir o curso planejado. O que você ganha se multiplicar sua posição horizontal final pela profundidade final?

Para começar, obtenha informações sobre o quebra-cabeça. (path: Dados/instrucoes-submarino.txt)


#### Parte 2

Com base em seus cálculos, o curso planejado não parece fazer nenhum sentido. Você encontra o manual do submarino e descobre que o processo é um pouco mais complicado.

Além da posição horizontal e da profundidade, você também precisará rastrear um terceiro valor, objetivo , que também começa em 0. Os comandos também significam algo totalmente diferente do que você pensava inicialmente:

- down X aumenta sua pontaria por X unidades.
- up X diminui seu objetivo por X unidades.
- forward X faz duas coisas:
    - Aumenta a sua posição horizontal por X unidades.
    - Ele aumenta sua profundidade multiplicando por sua pontaria X.

Mais uma vez, note que uma vez que você está em um submarino, downe upfazer o oposto do que você poderia esperar: "para baixo" significa visando no sentido positivo.

Agora, o exemplo acima faz algo diferente:

- forward 5 adiciona 5 à sua posição horizontal um total de 5. Porque seu objetivo é 0, sua profundidade não muda.
- down 5 adiciona 5ao seu objetivo, resultando em um valor de 5.
- forward 8 adiciona 8 à sua posição horizontal um total de 13. Porque seu objetivo é 5, sua profundidade aumenta 8 * 5 = 40.
- up 3 diminui seu objetivo em 3, resultando em um valor de 2.
- down 8 adiciona 8 ao seu objetivo, resultando em um valor de 10.
- forward 2 adiciona 2 à sua posição horizontal um total de 15 Porque seu objetivo é 10, sua profundidade aumenta 2 * 10 = 20 para um total de 60.

Depois de seguir essas novas instruções, você teria uma posição horizontal de 15e uma profundidade de 60. (Multiplicando estes produz 900.)

Usando esta nova interpretação dos comandos, calcule a posição horizontal e a profundidade que você teria após seguir o curso planejado. O que você ganha se multiplicar sua posição horizontal final pela profundidade final?

Embora não tenha mudado, você ainda pode obter informações sobre o quebra-cabeça. (path: Dados/instrucoes-submarino.txt)
