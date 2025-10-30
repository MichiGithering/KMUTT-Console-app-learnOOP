using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.D
{
    internal class BadDExample
    {
        private GoblinEnemy _enemy;

        public BadDExample()
        {
            // GameManager สร้างและพึ่งพา GoblinEnemy โดยตรง (Tight Coupling)
            _enemy = new GoblinEnemy();
        }

        public void StartWave()
        {
            Console.WriteLine("--- Game Manager Starts Wave ---");
            _enemy.Spawn();
            _enemy.PerformAction();
        }
    }
}
