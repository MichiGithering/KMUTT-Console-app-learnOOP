using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.O
{
    public enum WeaponType
    {
        Sword,
        Bow,
        Gun
    }
    internal class Weapon
    {
        public WeaponType Type { get; set; }
        public int BaseDamage { get; set; }

        public Weapon(WeaponType type, int baseDamage)
        {
            Type = type;
            BaseDamage = baseDamage;
        }
    }
}
}
