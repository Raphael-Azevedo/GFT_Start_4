using Exercicio1.Entities;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenteGeral = new Gerente("Raphael Azevedo", 24, 8000.50, 5);
            var supervisorArea = new Supervisor("Larissa", 28, 5000, 3);
            var vendedor1 = new Vendedor("Felipe", 24, 1300, 1);

            gerenteGeral.Bonificacao();
            supervisorArea.Bonificacao();
            vendedor1.Bonificacao();
        }

    }
}