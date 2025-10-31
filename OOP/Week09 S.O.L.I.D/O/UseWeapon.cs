using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.O
{
    internal class UseWeapon
    {

        public int BadCalculateDamage(Weapon weapon)
        {
            int totalDamage = weapon.BaseDamage;
            if (weapon.Type == WeaponType.Sword)
            {
                totalDamage += 5; // โบนัสดาบ
            }
            else if (weapon.Type == WeaponType.Bow)
            {
                totalDamage += 3; // โบนัสธนู
            }
            else if (weapon.Type == WeaponType.Gun)
            {
                totalDamage += 10; // โบนัสปืน
            }
            // ถ้าเพิ่ม WeaponType.Axe ต้องมาเพิ่ม else if ตรงนี้
            return totalDamage;
        }

        public int CalculateDamage(BonusWeapon weapon)
        {
            return weapon.GetDamage();
        }
    }
}
