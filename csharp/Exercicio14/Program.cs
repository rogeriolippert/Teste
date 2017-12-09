using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double PR1, PR2 = 0;
            double media = 0;

            Console.WriteLine("Digíte o resultado da 1º prova:");
            PR1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digíte o resultado da 2º prova:");
            PR2 = double.Parse(Console.ReadLine());

            media = (PR1 + PR2) / 2;
            Console.WriteLine("A Média do Aluno é: {0}", media);

        }
    }
}
