using System.Collections.Generic;

namespace app
{
    public class Campeonato
    {
        public List<Equipe> equipes;

        public Campeonato(){
            this.equipes = new List<Equipe>();
        }

        public void resultado() {
            this.equipes.ForEach(delegate(Equipe e){
                System.Console.WriteLine($"Equipe: {e.nome} - Pontuação: {e.pontuacao}");
            });   
        }
        
        public static List<Equipe> PreencheObjetos()
        {
            List<Equipe> list = new List<Equipe>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Equipe(){pontuacao  = i, nome = "Nome " + i });

            }
            return list;
        }
    }
}