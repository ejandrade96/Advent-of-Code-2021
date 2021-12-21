### Dia 8: Pesquisa de sete segmentos

Você mal alcança a segurança da caverna quando a baleia se choca contra a boca da caverna, derrubando-a. Os sensores indicam outra saída para esta caverna em uma profundidade muito maior, então você não tem escolha a não ser prosseguir.

À medida que o seu submarino percorre lentamente o seu caminho através do sistema de cavernas, você percebe que os **visores de sete segmentos de** quatro dígitos do seu submarino estão com defeito; eles devem ter sido danificados durante a fuga. Você terá muitos problemas sem eles, então é melhor você descobrir o que está errado.

Cada dígito de um display de sete segmentos é renderizado ligando ou desligando qualquer um dos sete segmentos nomeados **a** através de **g**:

![1](https://user-images.githubusercontent.com/57911863/146971541-36f24196-a5d7-4c10-9f2d-a2db8c8eeb99.png)

Portanto, para renderizar a **1**, apenas os segmentos **c** e **f** seriam ativados; o resto estaria desligado. Para renderizar uma **7**, apenas os segmentos **a**, **c** e **f** seria ligado.

O problema é que os sinais que controlam os segmentos foram misturados em cada display. O submarino está ainda a tentar mostrar os números de produção de saída em fios de sinal **a** através de **g**, mas estes cabos estão ligados aos segmentos **de forma aleatória**. Pior, as conexões de fio / segmento são misturadas separadamente para cada display de quatro dígitos! (Todos os dígitos **em** um display usam as mesmas conexões, no entanto.)

Então, você deve saber que apenas os fios de sinal **b** e **g** estão ligados, mas isso não significa **segmentos b** e **g** estão ligados: o único dígito que usa dois segmentos é **1**, então deve significar segmentos **c** e **f** deve estar ligado. Com apenas essas informações, você ainda não pode dizer qual fio (**b**/**g**) vai para qual segmento (**c**/**f**). Para isso, você precisará coletar mais informações.

Para cada exibição, você observa a mudança dos sinais por um tempo, anota **todos os dez padrões de sinal exclusivos** que vê e, a seguir, anota um único **valor de saída de quatro dígitos** (sua entrada de quebra-cabeça). Usando os padrões de sinal, você deve ser capaz de descobrir qual padrão corresponde a qual dígito.

Por exemplo, aqui está o que você pode ver em uma única entrada em suas notas:

![2](https://user-images.githubusercontent.com/57911863/146971555-1ad5f08d-6d5c-42aa-a32c-8935a7beb341.png)

(A entrada é quebrada aqui em duas linhas para que se encaixe; em suas notas, tudo estará em uma única linha.)

Cada entrada consiste em dez **padrões de sinal exclusivos**, um **|** delimitador e, finalmente, o **valor de saída de quatro dígitos**. Dentro de uma entrada, as mesmas conexões de fio / segmento são usadas (mas você não sabe quais são as conexões de fato). Os padrões de sinal exclusivos correspondem às dez maneiras diferentes com que o submarino tenta renderizar um dígito usando as conexões de fio / segmento atuais. Uma vez que **7** é o único dígito que utiliza três segmentos, **dab** no exemplo acima significa que para processar um **7**, as linhas de sinal **d**, **a** e **b** estão ligados. Uma vez que **4** é o único dígito que utiliza quatro segmentos, **eafb** os meios que tornam a um **4**, as linhas de sinal **e**, **a**, **f**, e **b** estão ligados.

Usando essas informações, você deve ser capaz de descobrir qual combinação de fios de sinal corresponde a cada um dos dez dígitos. Então, você pode decodificar o valor de saída de quatro dígitos. Infelizmente, no exemplo acima, todos os dígitos no valor de saída (**cdfeb fcadb cdfeb cdbaf**) usam cinco segmentos e são mais difíceis de deduzir.

Por enquanto, **concentre-se nos dígitos fáceis**. Considere este exemplo maior:

![3](https://user-images.githubusercontent.com/57911863/146971565-3c03aa14-2728-44d8-9fe9-5fad2d396b5e.png)

Porque os dígitos **1**, **4**, **7**, e **8** cada uso de um número único de segmentos, você deve ser capaz de dizer quais combinações de sinais correspondem aos dígitos. Contando **apenas dígitos nos valores de saída** (a parte depois **|** de cada linha), no exemplo acima, há **26** instâncias de dígitos que usam um número exclusivo de segmentos (destacado acima).

**Nos valores de saída, quantas vezes dígitos *1, 4, 7*, ou *8* aparece?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/input.txt)
