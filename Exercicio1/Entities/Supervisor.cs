namespace Exercicio1.Entities
{
    public class Supervisor : Colaborador
    {
        public Supervisor(string Nome, int Idade, double Salario, int GrauInstrucao) : base(Nome, Idade, Salario, GrauInstrucao)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Salario = Salario;
            this.GrauInstrucao = GrauInstrucao;
        }

        public override void Bonificacao()
        {
            var bonificacaoTotal = (500 * GrauInstrucao * 3) + this.Salario;
            System.Console.WriteLine("\nNome: " + this.Nome + " Idade: " + this.Idade +" Cargo: Supervisor" + " Salario Total: " + bonificacaoTotal);           
        }
    }
}