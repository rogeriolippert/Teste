using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nome, endereco, telefone = "";
 
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu Endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite seu Telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Seu Nome é {0}, e você mora em {1}, o número do seu telefone é {2}", nome, endereco, telefone);

        }
    }
}
