# Desafio-SOLID — Trilha Backend FDevs

Este repositório foi criado como parte da conclusão do desafio da trilha de Backend do programa **FDevs**. O projeto foi desenvolvido em **C#** com foco em aplicar os **princípios SOLID** de forma prática e didática.

Cada princípio é apresentado com dois exemplos:
- **Violação**: mostra um cenário onde o princípio não está sendo respeitado
- **Solução**: demonstra como aplicar o princípio corretamente, seguindo boas práticas de design de software

---

## 📚 Sobre os Princípios SOLID

Os princípios SOLID são um conjunto de boas práticas para desenvolvimento orientado a objetos, que ajudam a tornar o código mais **organizado**, **flexível**, **manutenível** e **escalável**.

Cada letra representa um princípio:

- **S — Single Responsibility Principle (SRP)**  
  Uma classe deve ter apenas uma responsabilidade.  
  > Exemplo: separar lógica de negócio, persistência e envio de e-mail em classes distintas.

- **O — Open/Closed Principle (OCP)**  
  As classes devem estar abertas para extensão, mas fechadas para modificação.  
  > Exemplo: aplicar descontos diferentes sem alterar a classe principal.

- **L — Liskov Substitution Principle (LSP)**  
  Subtipos devem poder substituir seus tipos base sem quebrar o sistema.  
  > Exemplo: garantir que subclasses respeitem o contrato da classe pai.

- **I — Interface Segregation Principle (ISP)**  
  Interfaces não devem forçar classes a implementar métodos que não utilizam.  
  > Exemplo: dividir uma interface genérica em interfaces específicas para cada tipo de serviço.

- **D — Dependency Inversion Principle (DIP)**  
  Módulos de alto nível não devem depender de módulos de baixo nível — ambos devem depender de abstrações.  
  > Exemplo: usar interfaces para desacoplar a lógica de pagamento da implementação concreta.


## 📁 Estrutura do projeto

Cada princípio está organizado em sua própria pasta, contendo:

- `Violacao/`: exemplo que **não respeita** o princípio
- `Solucao/`: exemplo que **aplica corretamente** o princípio

