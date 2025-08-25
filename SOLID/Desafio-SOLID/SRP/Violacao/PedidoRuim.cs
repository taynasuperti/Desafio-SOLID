// SRP (Single Responsibility Principle): nesse princípio, é falado que uma classe deve ter um único motivo para mudar, ela deve ter apenas uma responsabilidade  

namespace Desafio_SOLID.SRP.Violacao
{
    //declarando os dados do pedido
    internal class PedidoRuim
    {
        public int Id { get; set; }
        public decimal ValorItens { get; set; }
        public decimal ValorFrete { get; set; }

        //essa clase faz "de tudo", ela faz a regra de negócio, faz a persistência e envia email
        public decimal CalcularValorFinal()
        {
            //aqui vem a lógica para calcular o valor final do item (valor + frete)
            return ValorItens + ValorFrete;
        }

        public void SalvarNoBanco()
        {
            //aqui vem a lógica pra salvar o pedido no banco
            //simulação de como seria a conexão com o banco de dados
            Console.WriteLine($"[SRP Violação] Salvando pedido {Id} no banco...");
        }

        public void EnviarEmailConfirmacao()
        {
            //aqui vem a lógica pra enviar email de confirmação da compra
            //simulação de como seria o envio de email
            Console.WriteLine($"[SRP Violação] Enviando e-mail do pedido {Id}...");
        }
    }
}
