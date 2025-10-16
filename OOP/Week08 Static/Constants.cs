using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week08_Static
{
    public static class Constants // Static Class: คลาสที่ไม่สามารถสร้าง Instance ได้
    {
        // Static Readonly Field: ค่าคงที่ที่ถูกกำหนดค่าเมื่อ Class โหลด
        public const int MaxUsers = 100;     
        // public const ก็ถือเป็น static อยู่แล้ว
        // 1. const (Constant Field): ค่าคงที่ "ในระดับคอมไพล์" (Compile-Time)

        public static readonly double PiValue = 3.14159;
        // 2. readonly (Read-Only Field): ค่าคงที่ "ในระดับรันไทม์" (Run-Time)
        //    - สามารถกำหนดค่าได้ใน Constructor หรือที่จุดประกาศเท่านั้น

        // Static Method: สำหรับฟังก์ชันทั่วไป
        public static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
