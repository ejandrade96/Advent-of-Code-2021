### Dia 16: Decodificador de Pacote

Ao sair da caverna e chegar a águas abertas, você recebe uma transmissão dos Elfos de volta ao navio.

A transmissão foi enviada usando o Buoyancy Interchange Transmission System (BITS), um método de empacotamento de expressões numéricas em uma seqüência binária. O computador do seu submarino salvou a transmissão em **hexadecimal** (sua entrada no quebra-cabeça).

A primeira etapa da decodificação da mensagem é converter a representação hexadecimal em binária. Cada caractere de hexadecimal corresponde a quatro bits de dados binários:

image

A transmissão do BITS contém um único **pacote** em sua camada mais externa, que por sua vez contém muitos outros pacotes. A representação hexadecimal desse pacote pode codificar alguns **0** bits extras no final; eles não fazem parte da transmissão e devem ser ignorados.

Cada pacote começa com um cabeçalho padrão: os primeiros três bits codificam a **versão** do pacote e os três bits seguintes codificam a **ID do tipo** de pacote. Esses dois valores são números; todos os números codificados em qualquer pacote são representados como binários com o bit mais significativo primeiro. Por exemplo, uma versão codificada como a seqüência binária **100** representa o número **4**.

Os pacotes com ID de tipo **4** representam um **valor literal**. Os pacotes de valor literal codificam um único número binário. Para fazer isso, o número binário é preenchido com zeros à esquerda até que seu comprimento seja um múltiplo de quatro bits e, em seguida, é dividido em grupos de quatro bits. Cada grupo é prefixado por um **1** bit, exceto o último grupo, que é prefixado por um **0** bit. Esses grupos de cinco bits seguem imediatamente o cabeçalho do pacote. Por exemplo, a string hexadecimal **D2FE28** torna-se:

image

Abaixo de cada bit está um rótulo indicando sua finalidade:

- Os três bits marcados **V** (**110**) são a versão do pacote, **6**.

- Os três bits marcados **T** (**100**) são o ID do tipo de pacote **4**, o que significa que o pacote é um valor literal.

- Os cinco bits marcados com **A** (**10111**) começam com a **1** (não o último grupo, continue lendo) e contêm os primeiros quatro bits do número, **0111**.

- Os cinco bits marcados com **B** (**11110**) começam com a **1** (não o último grupo, continue lendo) e contêm mais quatro bits do número, **1110**.

- Os cinco bits marcados **C** (**00101**) começam com a **0** (último grupo, fim do pacote) e contêm os últimos quatro bits do número, **0101**.

- Os três **0** bits não rotulados no final são extras devido à representação hexadecimal e devem ser ignorados.

Portanto, este pacote representa um valor literal com representação binária **011111100101**, que é **2021** em decimal.

Todos os outros tipos de pacote (qualquer pacote com um ID de tipo diferente de **4**) representam um **operador** que executa alguns cálculos em um ou mais subpacotes contidos nele. No momento, as operações específicas não são importantes; foco na análise da hierarquia de subpacotes.

Um pacote de operador contém um ou mais pacotes. Para indicar quais dados binários subsequentes representam seus subpacotes, um pacote de operador pode usar um dos dois modos indicados pelo bit imediatamente após o cabeçalho do pacote; isso é chamado de **ID do tipo de comprimento**:

- Se o tipo de comprimento ID for **0**, então os próximos **15** bits são um número que representa o **comprimento total em bits** dos subpacotes contidos neste pacote.

- Se o tipo de comprimento ID for **1**, então os próximos **11** bits são um número que representa o **número de subpacotes contidos imediatamente** por este pacote.

Finalmente, após o bit de ID do tipo de comprimento e o campo de 15-bit ou 11-bit, os subpacotes aparecem.

Por exemplo, aqui está um pacote de operador (string hexadecimal **38006F45291200**) com ID de tipo de comprimento **0** que contém dois subpacotes:

image

- Os três bits marcados **V** (**001**) são a versão do pacote, **1**.

- Os três bits marcados **T** (**110**) são o ID do tipo de pacote, **6**, o que significa que o pacote é um operador.

- O bit rotulado **I** (**0**) é o ID do tipo de comprimento, que indica que o comprimento é um número de 15 bits que representa o número de bits nos subpacotes.

- Os 15 bits marcados **L** (**000000000011011**) contêm o comprimento dos subpacotes em bits, **27**.

- Os 11 bits marcados **A** contêm o primeiro subpacote, um valor literal que representa o número **10**.

- Os 16 bits marcados **B** contêm o segundo subpacote, um valor literal que representa o número **20**.

Após a leitura de 11 e 16 bits de dados de subpacote, o comprimento total indicado em **L** (27) é alcançado e, portanto, a análise deste pacote é interrompida.

Como outro exemplo, aqui está um pacote de operador (string hexadecimal **EE00D40C823060**) com ID de tipo de comprimento 1que contém três subpacotes:

image

- Os três bits marcados **V** (**111**) são a versão do pacote, **7**.

- Os três bits marcados **T** (**011**) são o ID do tipo de pacote, **3**, o que significa que o pacote é um operador.

- O bit rotulado **I** (**1**) é o ID do tipo de comprimento, que indica que o comprimento é um número de 11 bits que representa o número de subpacotes.

- Os 11 bits marcados **L** (**00000000011**) contêm o número de subpacotes, **3**.

- Os 11 bits marcados **A** contêm o primeiro subpacote, um valor literal que representa o número **1**.

- Os 11 bits marcados **B** contêm o segundo subpacote, um valor literal que representa o número **2**.

- Os 11 bits marcados **C** contêm o terceiro subpacote, um valor literal que representa o número **3**.

Depois de ler 3 subpacotes completos, o número de subpacotes indicado em **L** (3) é alcançado e, portanto, a análise deste pacote é interrompida.

Por enquanto, analise a hierarquia dos pacotes ao longo da transmissão e **some todos os números de versão**.

Aqui estão mais alguns exemplos de transmissões codificadas em hexadecimal:

- **8A004A801A8002F478** representa um pacote de operador (versão 4) que contém um pacote de operador (versão 1) que contém um pacote de operador (versão 5) que contém um valor literal (versão 6); este pacote tem uma soma de versão de **16**.

- **620080001611562C8802118E34** representa um pacote de operador (versão 3) que contém dois subpacotes; cada subpacote é um pacote de operador que contém dois valores literais. Este pacote tem uma soma de versão de **12**.

- **C0015000016115A2E0802F182340** tem a mesma estrutura do exemplo anterior, mas o pacote mais externo usa um ID de tipo de comprimento diferente. Este pacote tem uma soma de versão de **23**.

- **A0016C880162017C3686B18A3D4780** é um pacote de operador que contém um pacote de operador que contém um pacote de operador que contém cinco valores literais; ele tem uma soma de versão de **31**.

Decodifique a estrutura de sua transmissão BITS codificada em hexadecimal; **o que você ganha se somar os números de versão em todos os pacotes?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/input.txt)