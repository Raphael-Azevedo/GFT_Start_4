
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua Altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu Peso: ");
            double peso = double.Parse(Console.ReadLine());

            var imc = (peso / (altura * altura));
            if (imc < 18.5)
            {
                Console.WriteLine("\nNome: "+nome+"\nPeso: "+peso+"\nAltura: "+altura+"\nIndice de massa corporal: "+imc+"\nAbaixo do normal");
            }
            else if ((imc >= 18.5) && (imc < 25))
            {
                Console.WriteLine("\nNome: "+nome+"\nPeso: "+peso+"\nAltura: "+altura+"\nIndice de massa corporal: "+imc+"\nPeso normal");
            }
            else  if ((imc >= 25) && (imc < 30))
            {
                Console.WriteLine("\nNome: "+nome+"\nPeso: "+peso+"\nAltura: "+altura+"\nIndice de massa corporal: "+imc+"\nSobrepeso");
            }
            else if ((imc >= 30) && (imc < 35))
            {
                Console.WriteLine("\nNome: "+nome+"\nPeso: "+peso+"\nAltura: "+altura+"\nIndice de massa corporal: "+imc+"\nObesidade Grau I");
            }
            else if ((imc >= 35) && (imc < 40))
            {
                Console.WriteLine("\nNome: "+nome+"\nPeso: "+peso+"\nAltura: "+altura+"\nIndice de massa corporal: "+imc+"\nObesidade Grau II");
            }
            else  if (imc >= 40)
            {
                Console.WriteLine("\nNome: "+nome+"\nPeso: "+peso+"\nAltura: "+altura+"\nIndice de massa corporal: "+imc+"\nObesidade Grau III");
            }

        }

    }
}