using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.S
{
    internal class SaveProgress
    {
        public void Save(DataPlayer dataPlayer)
        {
            Console.WriteLine($"Saving game for {dataPlayer.PlayerName} to local file...");
            // Logic for saving player data to a file
        }
    }
}
