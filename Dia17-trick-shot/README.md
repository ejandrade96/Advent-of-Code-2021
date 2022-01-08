### Dia 17: Trick Shot

Você finalmente decodificou a mensagem dos Elfos. **HI**, diz a mensagem. Você continua procurando as chaves do trenó.

À sua frente está o que parece ser uma grande **trincheira oceânica**. Será que as chaves caíram nele? É melhor você enviar uma sonda para investigar.

O iniciador da sonda em seu submarino pode disparar a sonda com qualquer velocidade **inteira** nas direções **x** (para frente) e **y** (para cima ou para baixo se negativo). Por exemplo, uma **x,y** velocidade inicial como **0,10** dispararia a sonda para cima, enquanto uma velocidade inicial como **10,-1** dispararia a sonda para frente em um leve ângulo para baixo.

A **x,y** posição da sonda começa em **0,0**. Então, ele seguirá alguma trajetória movendo-se em **etapas**. Em cada etapa, essas mudanças ocorrem na seguinte ordem:

- A posição **x** da sonda aumenta em sua velocidade **x**.

- A posição **y** da sonda aumenta de acordo com sua velocidade **y**.

- Devido ao arrasto, a velocidade **x** da sonda muda em **1** em direção ao valor **0**; ou seja, diminui em **1** se for maior que **0**, aumenta em **1** se for menor que **0** ou não muda se já for **0**.

- Devido à gravidade, a velocidade **y** da sonda diminui em **1**.

Para que a sonda entre com sucesso na trincheira, ela deve estar em alguma trajetória que faça com que esteja dentro de uma **área alvo** após qualquer passo. O computador submarino já calculou esta área-alvo (sua entrada no quebra-cabeça). Por exemplo:

![1](https://user-images.githubusercontent.com/57911863/148652172-f5015faa-6683-4f45-a1c5-da66ff980ac3.png)

Esta área de destino significa que você precisa encontrar os **x,y** valores de velocidade inicial de forma que, após qualquer etapa, a **x** posição da sonda seja no mínimo **20** e no máximo **30**, **e** a **y** posição da sonda seja no mínimo **-10** e no máximo **-5**.

Dada esta área alvo, uma velocidade inicial que faz com que a sonda esteja dentro da área alvo após qualquer etapa é **7,2**:

![2](https://user-images.githubusercontent.com/57911863/148652179-99ed5063-58cb-4aec-9229-fd43806506f5.png)

Neste diagrama, **S** é a posição inicial da sonda, **0,0**. A **x** coordenada aumenta para a direita e a **y** coordenada aumenta para cima. No canto inferior direito, as posições que estão dentro da área de destino são mostradas como **T**. Após cada etapa (até que a área alvo seja alcançada), a posição da sonda é marcada com **#.** (O canto inferior direito **#** é uma posição que a sonda atinge e uma posição na área de destino.)

Outra velocidade inicial que faz com que a sonda esteja dentro da área alvo após qualquer etapa é **6,3**:

![3](https://user-images.githubusercontent.com/57911863/148652183-36e3b161-a5b8-4fe1-8642-9b7eff67790a.png)

Outro é **9,0**:

![4](https://user-images.githubusercontent.com/57911863/148652187-e32a3e97-e97d-4bd6-ac89-793c5bffa3f9.png)

Uma velocidade inicial que **não faz** com que a sonda fique dentro da área alvo após qualquer etapa é **17,-4**:

![5](https://user-images.githubusercontent.com/57911863/148652194-9b392e4d-7e4a-4005-9dd9-e2d79be6ab3b.png)

A sonda parece passar pela área de destino, mas nunca está dentro dela após qualquer etapa. Em vez disso, ele continua para baixo e para a direita - apenas as primeiras etapas são mostradas.

Se você vai disparar uma sonda altamente científica de um lançador de sonda super legal, você pode muito bem fazer isso com **estilo**. Quão alto você pode fazer a sonda ir enquanto ainda atinge a área de destino?

No exemplo acima, usar uma velocidade inicial de **6,9** é o melhor que você pode fazer, fazendo com que a sonda alcance uma **y** posição máxima de **45**. (Qualquer **y** velocidade inicial mais alta faz com que a sonda ultrapasse a área alvo inteiramente.)

Encontre a velocidade inicial que faz com que a sonda atinja a **y** posição mais alta e, eventualmente, ainda esteja dentro da área de destino após qualquer etapa. **Qual é a posição *y* mais alta que atinge nesta trajetória?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/input.txt)
