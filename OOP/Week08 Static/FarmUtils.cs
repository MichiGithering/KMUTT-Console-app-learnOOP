using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week08_Static
{
    internal static class FarmUtils
    {
        // 3A. const: ค่าคงที่ที่เป็นของคลาส ถูกกำหนด ณ Compile-Time
        public const int DefaultPens = 10;

        // 3B. static readonly: ค่าคงที่ที่ซับซ้อน กำหนดค่า ณ Run-Time (เมื่อคลาสถูกโหลด)
        public static readonly float Gravity = 9.81f;

        // Static Method: สำหรับการคำนวณที่ไม่เกี่ยวข้องกับสถานะของ Object ใดๆ
        public static int CalculateTotalPenCapacity(int capacityPerPen)
        {
            // ใช้งาน const ที่นี่
            return DefaultPens * capacityPerPen;
        }

        // Static Method: สำหรับแสดงข้อมูล
        public static void DisplayCurrentStatus()
        {
            Console.WriteLine($"\n--- FARM STATUS (via Static Class) ---");
            // เข้าถึง const และ static readonly โดยตรงผ่านชื่อคลาส
            Console.WriteLine($"Default Pens (const): {DefaultPens}");
            Console.WriteLine($"Gravity (static readonly): {Gravity}");

            // เข้าถึง Static Property ของ Sheep
            Console.WriteLine($"Total Sheep Population: {Sheep.TotalSheepCount}");
            Console.WriteLine($"Max Capacity (per pen 5): {CalculateTotalPenCapacity(5)}");
        }
    }
}
