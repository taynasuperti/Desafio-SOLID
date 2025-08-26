// LSP (Liskov Substitution Principle): nesse princípio, é falado que uma subclasse pode substituir a classe base sem alterar o funcionamento correto do projeto
// resumindo, se uma classe filha não consegue cumprir a msm funcionalidade da classe pai, ela está violando esse princípio
//caso algo dê errado, a classe filha deve subistituir e cumprir todas as "responsabilidades" da classe pai

namespace Desafio_SOLID.LSP.Violacao
{
    internal class EntregaRuim
    {
        //aqui é criado um método genérico para calcular o valor do frete
        public virtual decimal CalcularFrete()
        // o virtual permite que o método seja sobrescrito por uma classe filha
        {
            return 20.0m;
        }
    }
    class EntregaCorreiosRuim : EntregaRuim
    {
        //frete padrão dos correios
        public override decimal CalcularFrete()
        //o override serve para substituir a versão do método que veio da classe base
        {
            Console.WriteLine("[LSP Violação] Frete via Correios aplicado: R$20,00");
            return 20.0m;
        }
    }
    internal class RetiradaNaLojaRuim : EntregaRuim
    {
        //a violação desse princípo vem aqui:
        // essa classe não consegue cumprir o contrato da classe base (o pai calcula apenas frete, não existe funcionalidade nele pra retirada física do produto)
        // o projeto "quebra" pq a herança não consegue usar o método CalcularFrete()
        public override decimal CalcularFrete()
        {
            //simulação de erro ao tentar calcular frete para retirada
            throw new Exception("[LSP Violação] Retirada na loja não possui frete!");
        }
    }
}
