# POO-Atividade-Prática

Este projeto é um simulador de patos desenvolvido como atividade prática da disciplina de Programação Orientada a Objetos (POO).  
Seu objetivo é aplicar conceitos fundamentais como encapsulamento, herança, composição e padrões de projeto clássicos, promovendo boas práticas de design de software.

## Questões Propostas

**1. Modifique seu programa retirando todos os comportamentos que variam da classe Duck e os colocando em interfaces. Continue utilizando herança da classe Duck para o que se repete (ex: display).**

Foi feito. Os comportamentos que variam, como "voar" e "grasnar", foram extraídos da classe `Duck` e transferidos para as interfaces `IFlyable` e `IQuackable`.  
A classe base `Duck` agora contém apenas os comportamentos comuns, como `Name`, o método `Swim()` e a assinatura abstrata `Display()`.  
As classes derivadas implementam apenas as interfaces compatíveis com seus comportamentos específicos.

---

**2. Explique quais os principais ganhos desta estratégia.**

- Flexibilidade: permite combinar diferentes comportamentos de forma dinâmica.
- Reutilização de código: evita duplicação e promove reaproveitamento de funcionalidades.
- Organização: separa claramente o que é fixo do que é variável.
- Facilidade de manutenção: mudanças em um comportamento não afetam outros.
- Escalabilidade: o sistema fica preparado para incluir novos tipos de patos e habilidades com pouco impacto no restante do código.

---

**3. Você vê alguma desvantagem nesta estratégia?**

Não foram identificadas desvantagens significativas. Apesar de parecer uma abordagem sofisticada para um problema simples, a aplicação de interfaces e composição neste contexto reforça boas práticas de design orientado a objetos.

## Padrões de Projeto Aplicados

Este projeto utiliza os seguintes padrões de projeto para garantir flexibilidade, organização e extensibilidade do código:

### Strategy Pattern
Define comportamentos dinâmicos para os patos, como voar, grasnar, dançar ou ficar invisível.  
Cada comportamento é encapsulado em uma interface (como `IFlyable`, `IQuackable`, `IDanceable`, `IInvisible`), permitindo fácil substituição e combinação de comportamentos.

### Factory Method
A classe `DuckFactory` é responsável pela criação dos objetos `Duck`, facilitando a instância de diferentes tipos de patos com seus respectivos comportamentos.  
Essa abordagem desacopla a lógica de criação do restante da aplicação e facilita a expansão com novos tipos de patos.

### Command Pattern
As ações executadas pelos patos, como voar, dançar, ou emitir sons, são encapsuladas como comandos (`FlyCommand`, `DanceCommand`, etc.).  
Esse padrão desacopla a interface gráfica da lógica de execução dos comandos e torna o sistema mais modular e preparado para evoluções, como desfazer ações (undo) ou comandos compostos (macro commands).

## Princípios SOLID Aplicados
Este projeto também foi desenvolvido com base nos princípios SOLID, fundamentais para a construção de sistemas orientados a objetos bem estruturados e fáceis de manter:

### SRP — Single Responsibility Principle
Cada classe possui uma responsabilidade única.
Exemplos:

As classes que representam comportamentos (`FlyWithWings`, `QuackLoud`, `DanceSamba`, etc.) cuidam exclusivamente de seu comportamento específico.

A classe Duck centraliza apenas o que é comum entre todos os patos.

### OCP — Open/Closed Principle
O sistema está aberto para extensão, mas fechado para modificação.
É possível adicionar novos tipos de patos ou novos comportamentos sem alterar as classes existentes, graças ao uso de interfaces e composição.

### LSP — Liskov Substitution Principle
Todas as classes derivadas de `Duck` podem ser usadas onde se espera um Duck, sem comprometer o funcionamento do sistema.
O mesmo vale para os comandos e interfaces de comportamento.

### ISP — Interface Segregation Principle
Os comportamentos foram divididos em interfaces específicas (`IFlyable`, `IQuackable`, `IDanceable`, etc.), garantindo que as classes implementem apenas o que realmente utilizam.

### DIP — Dependency Inversion Principle
As classes dependem de abstrações em vez de implementações concretas.
Por exemplo, os patos recebem comportamentos que implementam interfaces (`IFlyable`, `IQuackable`) sem conhecer os detalhes internos dessas implementações.
