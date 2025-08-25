// SRP (Single Responsibility Principle): nesse princípio, é falado que uma classe deve ter um único motivo para mudar, ela deve ter apenas uma responsabilidade  

namespace Desafio_SOLID.SRP.Solucao
{
    //aqui, cada classe tem a sua responsabilidade única
    internal class PedidoBom
    {
        //declarando os dados do pedido
        public int Id { get; set; }
        public decimal ValorItens { get; set; }
        public decimal ValorFrete { get; set; }

        public decimal CalcularValorFinal()
        {
            //aqui vem a lógica para calcular o valor final do item (valor + frete)
            return ValorItens + ValorFrete;
        }
    }

    internal class SalvarPedido
    {
        public void SalvarNoBanco(int id)
        {
            //aqui vem a lógica pra salvar o pedido no banco
            //simulação de como seria a conexão com o banco de dados
            Console.WriteLine($"[SRP Solução] Salvando pedido {id} no banco...");
        }
    }

    internal class EnviarEmail
    {
        public void EnviarEmailConfirmacao(int id)
        {
            //aqui vem a lógica pra enviar email de confirmação da compra
            //simulação de como seria o envio de email
            Console.WriteLine($"[SRP Solução] Enviando e-mail de confirmação do pedido {id}...");
        }
    }
}
