using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int sucessor, antecessor = 0;
            Console.WriteLine("# Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            //Processa
            sucessor = numero  + 1;
            antecessor = numero - 1;
            //Imprime 
            Console.WriteLine("Sucessor do número é: {0}", sucessor);
            Console.WriteLine("Antecessor do número é: {0}", antecessor);
        }
    }
}