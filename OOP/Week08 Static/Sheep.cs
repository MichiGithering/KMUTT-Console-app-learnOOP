using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week08_Static
{
    internal class Sheep
    {

        // Instance Field
        private int SheepNumber;
        // Static Field ที่ใช้เก็บค่ารวมของแกะ
        private static int _totalSheepCount;

        // Static Field เพื่อจำลองค่าเริ่มต้นที่โหลดจากไฟล์ตั้งค่า
        private static readonly int _initialPopulation;

        // 1. Static Constructor: ถูกเรียกครั้งเดียว ก่อนการสร้าง Object หรือการเข้าถึง Static Member แรก
        static Sheep()
        {
            Console.WriteLine("--- Sheep Class Loaded: Running Static Constructor ---");
            // สมมติว่านี่คือการโหลดค่าเริ่มต้นจากฐานข้อมูลหรือไฟล์
            _initialPopulation = 5;
            _totalSheepCount = _initialPopulation;
            Console.WriteLine($"Starting population set to: {_initialPopulation}");
        }

        // 2. Static Property: ให้การเข้าถึงค่า Static Field อย่างปลอดภัยและควบคุมได้
        public static int TotalSheepCount
        {
            get { return _totalSheepCount; }
            // ไม่มี 'set' เพราะต้องการให้เป็นแบบอ่านอย่างเดียวภายนอก
        }


        // Instance Constructor
        public Sheep(int n)
        {
            this.SheepNumber = n;
            _totalSheepCount++; // ทุกครั้งที่สร้าง Object จะเพิ่มตัวนับ Static
            Console.WriteLine($"Sheep created in pen {SheepNumber}.");
        }

        // Instance Method
        public int AskNumber()
        {
            return SheepNumber;
        }
        public void SetNumber(int n)
        {
            SheepNumber = n;
        }
        // Static Method (เหมือนเดิม)
        public static void RemoveSheep(int count)
        {
            _totalSheepCount -= count;
            Console.WriteLine($"{count} sheep removed. Current total: {_totalSheepCount}");
        }
        public static int GetAllSheep(int count)
        {
            return _totalSheepCount;
        }

        public void Jump() {
            Console.WriteLine("Sheep get Gravity " + FarmUtils.Gravity);
        }
    }
}
