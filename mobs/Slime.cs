using System;
using Rpg;

namespace RpgSystem
{
    class Slime : Entidade
    {
        public Slime()
        {
            status.name = "Slime Selvagem";
            status.attack = 3;
            status.defense = 3;
            status.hp = 3;
            Console.WriteLine($"Um {status.name} apareceu");
        }
    }
}