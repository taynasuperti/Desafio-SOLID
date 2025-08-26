// ISP (Interface Segregation Principle): nesse princípio, é falado que nenhuma classe deve ser forçada a implementar métodos que não utiliza

namespace Desafio_SOLID.ISP.Violacao
{
    internal class ServicoPosVendaRuim
    {
        //aqui representa uma interface que define vários serviços pós-venda
        interface IServicoPosVenda
        {
            void EnviarEmailConfirmacao();
            void AgendarInstalacao();
            void RegistrarGarantia();
        }

        //o produto físico precisa de todos os serviços
        internal class ProdutoFisico: IServicoPosVenda
        {
            public void EnviarEmailConfirmacao()
            {
                //simulação de envio de e-mail
                Console.WriteLine("[ISP Violação] Enviando e-mail de confirmação...");
            }

            public void AgendarInstalacao()
            {
                //simulação de agendamento de instalação
                Console.WriteLine("[ISP Violação] Agendando instalação do produto...");
            }

            public void RegistrarGarantia()
            {
                //simulação de registro de garantia
                Console.WriteLine("[ISP Violação] Registrando garantia do produto...");
            }
        }

        //aqui vem a violação desse princípio: produto digital não precisa de instalação, mas é forçado a implementar o método
        internal class ProdutoDigital : IServicoPosVenda
        {
            public void EnviarEmailConfirmacao()
            {
                //simulação de envio de e-mail
                Console.WriteLine("[ISP Violação] Enviando e-mail de confirmação...");
            }

            public void AgendarInstalacao()
            {
                // esse método não faz sentido para produto digital
                Console.WriteLine("[ISP Violação] Produto digital não precisa de instalação!");
            }

            public void RegistrarGarantia()
            {
                //simulação de registro de garantia
                Console.WriteLine("[ISP Violação] Registrando garantia do produto...");
            }
        }
    }
}
