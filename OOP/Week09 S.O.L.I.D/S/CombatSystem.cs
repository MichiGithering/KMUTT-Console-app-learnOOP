using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.S
{
    internal class CombatSystem
    {
        public void TakeDamage(DataPlayer dataPlayer,int amount)
        {
            dataPlayer.Health -= amount;
            Console.WriteLine($"{dataPlayer.PlayerName} took {amount} damage. Health: {dataPlayer.Health}");
            if (dataPlayer.Health <= 0)
            {
                Console.WriteLine($"{dataPlayer.PlayerName} has been defeated!");
            }
        }
    }
}
