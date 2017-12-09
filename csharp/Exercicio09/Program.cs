using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 = 0;
            int resultado = 0;
            
            Console.WriteLine("Digíte  o 1º número :");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digíte  o 2º número :");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;
            Console.WriteLine(" A soma é {0} ", resultado);
        }
    }
}
