// OCP (Open Closed Principle): nesse princípio, é falado que as classes devem ser abertas para extensão, mas fechadas para modificação
// resumindo, é possível adicionar coisas novas a uma classe, mas não deve mudar o que já está funcionando nela.

namespace Desafio_SOLID.OCP.Solucao
{
    //usei o abstract para que essa classe não possa ser instanciada diretamente
    //(não deixa criar um objeto diretamente da classe abstrata)
    internal abstract class DescontoCliente
    {
        public abstract double CalcularDescontoCliente();
    }

    class DescontoClienteComum : DescontoCliente //indica a herança da class 
    {
        public override double CalcularDescontoCliente()
        //o override serve para substituir a versão do método que veio da classe base
        {
            return 0.05; //5% de desconto
        }
    }

    class DescontoClienteVIP : DescontoCliente //indica a herança da class 
    {
        public override double CalcularDescontoCliente()
        {
            return 0.1; //10% de desconto
        }
    }

    internal class DescontoBom
    {
        //aqui, cada cliente tem a sua própria classe
        //se for necessário adicionar um novo tipo de cliente, não é necessário alterar essa classe
        public double AplicarDesconto(DescontoCliente cliente)
        {
            return cliente.CalcularDescontoCliente();
        }
    }
}
