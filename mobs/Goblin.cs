using System;
using Rpg;

namespace RpgSystem
{
    class Goblin : Stats
    {
        public Goblin ()
        {
        name = "Goblin Selvagem";
        attack = 5;
        hp = 5;
        defense = 5;
        Console.WriteLine($"Um {name} apareceu");
        }

    }
}