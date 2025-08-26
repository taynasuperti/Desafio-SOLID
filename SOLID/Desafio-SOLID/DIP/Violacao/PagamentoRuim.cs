// DIP (Dependency Inversion Principle): nesse princípio, é falado que módulos de alto nível não devem depender de módulos de baixo nível
// ambos devem depender de abstrações. além disso, abstrações não devem depender de detalhes, os detalhes devem depender das abstrações

namespace Desafio_SOLID.DIP.Violacao
{
    //essa classe representa o pagamento de um pedido
    internal class PagamentoRuim
    {
        //a violação desse princípio vem aqui, pq a classe depende diretamente de uma implementação concreta (Boleto)
        private Boleto boleto = new Boleto();

        public void PagarPedido()
        {
            //simulação de pagamento com boleto
            boleto.Pagar();
        }
    }

    //esse é o erro, a classe acima só funciona pq essa classe concreta realiza o pagamento via boleto
    internal class Boleto
    {
        public void Pagar()
        {
            Console.WriteLine("[DIP Violação] Pagamento com boleto realizado.");
        }
    }
}
