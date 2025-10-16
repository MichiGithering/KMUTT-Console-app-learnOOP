using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week08_Static
{
    public class AppCounter
    {
        // 1. Static Field: ตัวแปรที่ใช้ร่วมกันทุก Instance
        private static int _instanceCount = 0;

        // 2. Static Constructor: ถูกเรียกครั้งแรกก่อนการใช้งาน Static Member อื่นๆ หรือก่อนการสร้าง Instance แรก
        static AppCounter()
        {
            Console.WriteLine("--- Static Constructor: AppCounter Class ถูกโหลดแล้ว ---");
            // มักใช้เพื่อตั้งค่าเริ่มต้นให้กับ Static Fields ที่ต้องการ Logic ซับซ้อน
        }

        // 3. Static Property: สำหรับเข้าถึง Static Field อย่างปลอดภัย
        public static int InstanceCount
        {
            get { return _instanceCount; }
            // Singleton/Static มักใช้ setter แบบ private หรือไม่มีเลย เพื่อควบคุม
        }

        // Instance Constructor: ถูกเรียกเมื่อสร้างออบเจกต์ใหม่
        public AppCounter()
        {
            _instanceCount++; // ทุกครั้งที่สร้างออบเจกต์ จะเพิ่มค่า Static Field
            Console.WriteLine($"AppCounter Instance Created. Current count: {_instanceCount}");
        }

        // 4. Static Method: เมธอดที่ไม่ต้องใช้ออบเจกต์
        public static void ResetCounter()
        {
            _instanceCount = 0;
            Console.WriteLine("Counter has been reset.");
        }
    }
}
