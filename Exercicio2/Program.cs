
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero com no minimo 3 Digitos entre 350 e 8750");
            string numero = Console.ReadLine();

            while (numero.Length <= 3 || int.Parse(numero) < 350 || int.Parse(numero) > 8750)
            {
                if(numero.Length < 3)
                {
                    Console.WriteLine("O número deve conter no minimo 3 digitos! digite novemente:");
                    numero = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("O número deve ser entre 350 a 8750 digite novemente:");
                    numero = Console.ReadLine();
                }
            }
               
            int nImpares = 0;

            foreach (char algarismo in numero)
            {
                int valor = (int)(algarismo);
                if (valor % 2 != 0) nImpares++;
            }

            Console.WriteLine(nImpares);
        }

    }
}