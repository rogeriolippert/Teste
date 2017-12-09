using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2 = 0;
            double resultado = 0;

            Console.WriteLine("Digíte o seu 1º número:");
            n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digíte o seu 2º número:");
            n2 = double.Parse(Console.ReadLine());

            resultado = (n1 + n2) / 2;
            Console.WriteLine("A média é: {0}", resultado);
        }
    }
}
