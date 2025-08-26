// ISP (Interface Segregation Principle): nesse princípio, é falado que nenhuma classe deve ser forçada a implementar métodos que não utiliza

namespace Desafio_SOLID.ISP.Solucao
{
    internal class ServicoPosVendaBom
    {
        //aqui, cada serviço tem uma interface separada
        internal interface IEmailConfirmacao
        {
            void EnviarEmailConfirmacao();
        }

        internal interface IInstalacao
        {
            void AgendarInstalacao();
        }

        internal interface IGarantia
        {
            void RegistrarGarantia();
        }

        //o produto físico precisa de todos os serviços
        internal class ProdutoFisico: IEmailConfirmacao, IInstalacao, IGarantia
        {
            public void EnviarEmailConfirmacao()
            {
                //simulação de envio de e-mail
                Console.WriteLine("[ISP Solução] Enviando e-mail de confirmação...");
            }
            public void AgendarInstalacao()
            {
                //simulação de agendamento de instalação
                Console.WriteLine("[ISP Solução] Agendando instalação do produto...");
            }
            public void RegistrarGarantia()
            {
                //simulação de registro de garantia
                Console.WriteLine("[ISP Solução] Registrando garantia do produto...");
            }
        }
        //o produto digital implementa apenas o que precisa
        internal class ProdutoDigital: IEmailConfirmacao, IGarantia
        {
            public void EnviarEmailConfirmacao()
            {
                //simulação de envio de e-mail
                Console.WriteLine("[ISP Solução] Enviando e-mail de confirmação...");
            }
            public void RegistrarGarantia()
            {
                //simulação de registro de garantia
                Console.WriteLine("[ISP Solução] Registrando garantia do produto...");
            }
        }
    }
}
