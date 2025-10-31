using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.D
{
    internal class GoblinEnemy : Enemy
    {
        public override void Spawn()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Goblin] A new Goblin has spawned at (5, 5).");
            Console.ResetColor();
        }

        public override void PerformAction()
        {
            Console.WriteLine("[Goblin] Goblin attacks the player!");
        }
    }
}
