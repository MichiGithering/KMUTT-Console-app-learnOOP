using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.O
{
    internal class Sword : BonusWeapon
    {
        public int damage = 3;
        public int GetDamage()
        {
            return damage;
        }
    }
}
