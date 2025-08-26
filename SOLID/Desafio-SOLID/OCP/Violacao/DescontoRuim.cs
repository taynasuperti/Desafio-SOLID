// OCP (Open Closed Principle): nesse princípio, é falado que as classes devem ser abertas para extensão, mas fechadas para modificação
// resumindo,é possível adicionar coisas novas a uma classe, mas não deve mudar o que já está funcionando nela.

namespace Desafio_SOLID.OCP.Violacao
{
    internal class DescontoRuim
    {
        //o erro aqui é  por toda vez que for criado um novo tipo de cliente para calcular o desconto, a classe vai precisar ser alterada novamente
        public double CalcularDescontoCliente(string TipoCliente)
        {
            //esse tipo de ação pode "quebrar" o código se usada em grandes sistemas
            if(TipoCliente == "Comum")
            {
                //simulação de como seria a exposição do desconto
                Console.WriteLine($"[OCP Violação] Desconto aplicado: {CalcularDescontoCliente("Comum")}");
                return 0.05; //5% de desconto
            } else if (TipoCliente == "VIP")
            {
                //simulação de como seria a exposição do desconto
                Console.WriteLine($"[OCP Violação] Desconto aplicado: {CalcularDescontoCliente("VIP")}");
                return 0.1; //10% de desconto

            }
            else
            {
                //simulação de como seria a exposição do desconto
                Console.WriteLine($"[OCP Violação] Desconto aplicado: {CalcularDescontoCliente("0")}");
                return 0; //sem desconto
            }
        }
    }
}
