using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.S
{
    internal class PlayerCharacter
    {
        public int Health;
        public string PlayerName;
        public float PositionX;
        public float PositionY;

        // 1. หน้าที่เกี่ยวกับการเคลื่อนที่
        public void Move(float deltaX, float deltaY)
        {
            PositionX += deltaX;
            PositionY += deltaY;
            Console.WriteLine($"{PlayerName} moved to ({PositionX}, {PositionY})");
        }

        // 2. หน้าที่เกี่ยวกับการต่อสู้
        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{PlayerName} took {amount} damage. Health: {Health}");
            if (Health <= 0)
            {
                Console.WriteLine($"{PlayerName} has been defeated!");
            }
        }
        // 3. หน้าที่เกี่ยวกับการบันทึก/โหลดเกม
        public void SaveProgress()
        {
            Console.WriteLine($"Saving game for {PlayerName} to local file...");
            // Logic for saving player data to a file
        }
    }
}
