using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabela Brasileirão");
            
            ConsoleKeyInfo a;
            Campeonato campeonato = new Campeonato();
            do {
                Console.Write("Digite sua opção: ");
                a = Console.ReadKey();            
                if (a.Key == ConsoleKey.F5) {
                    System.Console.WriteLine("# Adicionando uma nova equipe");
                    System.Console.WriteLine("Digite o nome da equipe: "); 
                    string nome = Console.ReadLine();
                    System.Console.WriteLine("Digite a pontuacao: "); 
                    string pontuacao = Console.ReadLine();
                    campeonato.equipes.Add(new Equipe(nome, Int32.Parse(pontuacao)));
                }
            } while (a.Key != ConsoleKey.F4);

            System.Console.WriteLine("Listando o resultado");
            campeonato.resultado();

             List<Equipe> objetos = Program.PreencheObjetos();

             objetos.OrderBy(a => a.nome);
             objetos.OrderBy(a => a.pontuacao);
             objetos.OrderByDescending(a => a.nome);
             objetos.OrderByDescending(a => a.pontuacao);

        }
    }
}