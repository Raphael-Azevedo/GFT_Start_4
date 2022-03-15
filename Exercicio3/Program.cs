using Exercicio3.Entities;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente(123456,"Raphael Azevedo",1000);
            ContaPoupanca cp = new ContaPoupanca(123456,"Raphael Azevedo",1000);

            cc.Rendimento();
            cp.Rendimento();
        }

    }
}