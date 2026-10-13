using System;

namespace RpgSystem
{

    class Rpg
    {
        static void Main()
        {
            Entidade Protagonista = new Entidade();
            Protagonista.CriarProtagonista();
            
            Entidade Rival = new Entidade();
            Rival.CriarRival();

            Goblin GoblinSelvagem = new Goblin();
            Console.WriteLine("Seja bem vindo ao mundo de Autrora,");
            Console.WriteLine($"O mundo começa com um duelo contra o seu rival\n {Protagonista} vs {Rival} "); // ainda não funciona
            
            // Protagonista.Menu();  Isso aqui é uma função para status
        }
    }
}
