namespace Exercicio1.Entities
{
    public abstract class Colaborador
    {
        public Colaborador(string Nome, int Idade, double Salario, int GrauInstrucao)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Salario = Salario;
            this.GrauInstrucao = GrauInstrucao;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }
        public int GrauInstrucao { get; set; }

        public virtual void Bonificacao()
        {
            System.Console.WriteLine("\nNome: " + this.Nome + " Idade: " + this.Idade +" Cargo: " + " Salario Total: ");
        }
    }
}