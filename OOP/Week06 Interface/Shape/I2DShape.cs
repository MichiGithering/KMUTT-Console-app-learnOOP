using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface
{
    internal interface I2DShape
    {
        // คุณสมบัติ (Properties) สำหรับสีของรูปทรง
        // Interfaces ใน C# สามารถกำหนด properties ได้
        string Name { get; }
        string Color { get; set; }
      

        // เมธอดสำหรับวาดรูปทรง
        void Draw();

        // เมธอดสำหรับคำนวณพื้นที่
        double CalculateArea();

        // เมธอดสำหรับแสดงรายละเอียดทั้งหมด
        void PrintDetails();
    }
}
