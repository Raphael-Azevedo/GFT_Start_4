namespace Exercicio1.Entities
{
    public class Gerente : Colaborador
    {
        public Gerente(string Nome, int Idade, double Salario, int GrauInstrucao) : base(Nome, Idade, Salario, GrauInstrucao)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Salario = Salario;
            this.GrauInstrucao = GrauInstrucao;
        }
        public override void Bonificacao()
        {
            var bonificacaoTotal = (1000 * GrauInstrucao * 2) + this.Salario;
            System.Console.WriteLine("\nNome: " + this.Nome + " Idade: " + this.Idade +" Cargo: Gerente" + " Salario Total: " + bonificacaoTotal);           
        }

    }
}