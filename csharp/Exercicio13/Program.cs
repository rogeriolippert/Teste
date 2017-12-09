using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;
            double reajuste = 0;
            double juros = 0;
            Console.WriteLine("Digíte o saldo da sua aplicação: ");
            saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digíte o Juro:");
            juros = double.Parse(Console.ReadLine());

            reajuste = saldo * (juros / 100);
            saldo = saldo + reajuste;
            Console.WriteLine("O seu Saldo agora é:{0:#.00} ", saldo);


        }
    }
}
