namespace Exercicio3.Entities
{
    public abstract class Conta
    {
        public Conta(int Numero, string Titular, double Saldo)
        {
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = Saldo;
        }
        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private String _titular;
        public String Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public virtual void Rendimento()
        {
            Console.WriteLine("\nNumero da conta: "+this.Numero+"\nTitular: "+this.Titular+"\nSaldo da conta: "+this.Saldo+"\nRendimento: " + this.Saldo);
        }
    }
}