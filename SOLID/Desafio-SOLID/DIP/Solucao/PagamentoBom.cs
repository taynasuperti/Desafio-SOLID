// DIP (Dependency Inversion Principle): nesse princípio, é falado que módulos de alto nível não devem depender de módulos de baixo nível
// ambos devem depender de abstrações. além disso, abstrações não devem depender de detalhes, os detalhes devem depender das abstrações

namespace Desafio_SOLID.DIP.Solucao
{
    //aqui, é criada a interface para o pagamento
    internal interface IPagamento
    {
        void Pagar();
    }

    //implementação concreta para pagamento via boleto
    internal class PagamentoComBoleto : IPagamento
    {
        public void Pagar()
        {
            Console.WriteLine("[DIP Solução] Pagamento com boleto realizado.");
        }
    }

    //implementação concreta para pagamento via cartão
    internal class PagamentoComCartao : IPagamento
    {
        public void Pagar()
        {
            Console.WriteLine("[DIP Solução] Pagamento com cartão realizado.");
        }
    }

    //classe principal que representa o pagamento de um pedido
    internal class PagamentoBom
    {
        private readonly IPagamento _pagamento;

        //aqui, a dependência é invertida, a classe depende de uma abstração
        //aqui, a classe principal vem abaixo para respeitar a ordem de dependência
        public PagamentoBom(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public void PagarPedido()
        {
            _pagamento.Pagar();
        }
    }
}
