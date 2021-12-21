### Dia 7: A Traição das Baleias

Uma **baleia** gigante decidiu que seu submarino é a próxima refeição e é muito mais rápido do que você. Não há para onde correr!

De repente, um enxame de caranguejos (cada um em seu próprio submarino - é muito profundo para eles) se aproxima para resgatá-lo! Eles parecem estar se preparando para abrir um buraco no fundo do oceano; sensores indicam um **enorme sistema de cavernas subterrâneas** logo além de onde estão mirando!

Todos os submarinos caranguejos precisam ser alinhados antes de terem energia suficiente para abrir um buraco grande o suficiente para o seu submarino passar. No entanto, não parece que eles estarão alinhados antes que a baleia o pegue! Talvez você possa ajudar?

Há um grande problema - os submarinos caranguejos só podem se mover horizontalmente.

Você rapidamente faz uma lista da **posição horizontal de cada caranguejo** (sua entrada no quebra-cabeça). Os submarinos caranguejos têm combustível limitado, então você precisa encontrar uma maneira de fazer todas as suas posições horizontais coincidirem, exigindo que eles gastem o mínimo de combustível possível.

**16,1,2,0,4,2,7,1,2,14**

Isso significa que há um caranguejo com posição horizontal **16**, um caranguejo com posição horizontal 1e assim por diante.

Cada mudança de 1 passo na posição horizontal de um único caranguejo custa 1 combustível. Você pode escolher qualquer posição horizontal para alinhá-los, mas a que custa menos combustível é a posição horizontal **2**:

- Mover de **16** para **2**: **14** combustível
- Mover de **1** para **2**: **1** combustível
- Mover de **2** para **2**: **0** combustível
- Mover de **0** para **2**: **2** combustível
- Mover de **4** para **2**: **2** combustível
- Mover de **2** para **2**: **0** combustível
- Mover de **7** para **2**: **5** combustível
- Mover de **1** para **2**: **1** combustível
- Mover de **2** para **2**: **0** combustível
- Mover de **14** para **2**: **12** combustível

Isso custa um total de **37** combustível. Este é o resultado mais barato possível; resultados mais caros incluem alinhamento na posição **1** (**41** combustível), posição **3** (**39** combustível) ou posição **10** (**71** combustível).

Determine a posição horizontal que os caranguejos podem se alinhar usando o mínimo de combustível possível. **Quanto combustível eles devem gastar para se alinhar a essa posição?**

Para começar, **obtenha informações sobre o quebra-cabeça**. (path: Dados/posicoes-horizontais-caranguejos.txt)
