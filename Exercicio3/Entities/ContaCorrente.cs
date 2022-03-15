namespace Exercicio3.Entities
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int Numero, string Titular, double Saldo) : base(Numero, Titular, Saldo)
        {
        }
        public virtual void Rendimento()
        {
            Console.WriteLine("\nNumero da conta: "+this.Numero+"\nTitular: "+this.Titular+"\nSaldo da conta: "+this.Saldo+"\nRendimento na Conta Corrente: " + ((this.Saldo * 0.05)-0.75));
        }
    }
}