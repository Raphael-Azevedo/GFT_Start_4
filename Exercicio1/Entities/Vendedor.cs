namespace Exercicio1.Entities
{
    public class Vendedor : Colaborador
    {
        public Vendedor(string Nome, int Idade, double Salario, int GrauInstrucao) : base(Nome, Idade, Salario, GrauInstrucao)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Salario = Salario;
            this.GrauInstrucao = GrauInstrucao;
        }
        public override void Bonificacao()
        {
            var bonificacaoTotal = (300 * GrauInstrucao * 4) + this.Salario;
            System.Console.WriteLine("\nNome: " + this.Nome + " Idade: " + this.Idade +" Cargo: Vendedor" + " Salario Total: " + bonificacaoTotal);           
        }
    }
}