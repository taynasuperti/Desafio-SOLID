// LSP (Liskov Substitution Principle): nesse princípio, é falado que uma subclasse pode substituir a classe base sem alterar o funcionamento correto do projeto
// resumindo, se uma classe filha não consegue cumprir a mesma funcionalidade da classe pai, ela está violando esse princípio
// caso algo dê errado, a classe filha deve substituir e cumprir todas as "responsabilidades" da classe pai

namespace Desafio_SOLID.LSP.Solucao
{
    //aqui, cada tipo de entrega define seu próprio comportamento 
    //desse modo, o programa não "quebra" porque as classes filhas têm seu próprio comportamento
    internal class EntregaBoa
    {
        public int IdPedido { get; set; }
        public string MetodoEntrega { get; set; } = string.Empty;

        
        public void ExibirDados()
        {
            //simulação da exibição dos dados da entrega
            Console.WriteLine($"[LSP Solução] Pedido {IdPedido} será entregue via: {MetodoEntrega}");
        }
    }

    //usei o abstract para que essa classe não possa ser instanciada diretamente
    //(não deixa criar um objeto diretamente da classe abstrata)
    internal abstract class TipoEntrega
    {
        public abstract void ProcessarEntrega();
    }

    internal class EntregaCorreios : TipoEntrega
    {
        public override void ProcessarEntrega()
        {
            //simulação de envio pelos correios
            Console.WriteLine("[LSP Solução] Enviando pelos Correios. Frete: R$20,00");
        }
    }

    internal class RetiradaNaLoja : TipoEntrega
    {
        public override void ProcessarEntrega()
        {
            //simulação de retirada na loja
            Console.WriteLine("[LSP Solução] Cliente vai retirar na loja. Sem frete.");
        }
    }
}
