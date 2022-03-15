namespace Exercicio3.Entities
{
    public class ContaPoupanca : Conta
    {
         public ContaPoupanca(int Numero, string Titular, double Saldo) : base(Numero, Titular, Saldo)
        {
        }
        public virtual void Rendimento()
        {
            Console.WriteLine("\nNumero da conta: "+this.Numero+"\nTitular: "+this.Titular+"\nSaldo da conta: "+this.Saldo+"\nRendimento na Conta Poupança: " + (this.Saldo * 0.07));
        }
    }
}