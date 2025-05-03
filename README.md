# POO-Atividade-Prática

Modifique seu programa Simulador de Patos retirando todos os comportamentos que variam da classe Duck e os colocando em interfaces. Continue utilizando herança da Classe Duck para o que repete (ex: display) e faça a escrita dos métodos assinados nas interfaces?

R: Feito! Os comportamentos que variam, como "voar" e "grasnar", foram extraídos da classe Duck e transferidos para as interfaces IFlyable e IQuackable. A classe base Duck agora contém apenas os comportamentos comuns a todos os patos, como o nome, o método Swim() e a assinatura abstrata Display(). As classes derivadas implementam apenas as interfaces compatíveis com seus comportamentos.

Explique quais os principais ganhos desta estratégia?
R: Os principais ganhos são:

  Flexibilidade: permite combinar diferentes comportamentos conforme necessário.
  Reutilização de código: evita duplicações e facilita o reaproveitamento de funcionalidades.
  Melhor organização: separa claramente o que varia do que é fixo, deixando o código mais limpo.
  Facilidade de manutenção: mudanças em um comportamento não afetam outras partes do sistema.
  Escalabilidade: o sistema fica mais preparado para crescer e adaptar novos tipos de patos.

Você a capaz de ver alguma desvantagem nesta estratégia?
R: Não.
