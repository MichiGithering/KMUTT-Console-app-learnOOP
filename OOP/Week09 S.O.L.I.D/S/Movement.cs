using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.S
{
    internal class Movement
    {
        public void Move(DataPlayer dataPlayer, float deltaX ,float deltaY)
        {
            dataPlayer.PositionX = deltaX;
            dataPlayer.PositionY = deltaY;
            Console.WriteLine($"{dataPlayer.PlayerName} moved to {dataPlayer.PositionX} {dataPlayer.PositionY}");
        }
    }
}
