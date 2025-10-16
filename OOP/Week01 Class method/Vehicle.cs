using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Vehicle
    {
        // คุณสมบัติ (Properties) ที่ทุกคลาสลูกจะได้รับ
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // คอนสตรักเตอร์ (Constructor) ที่จะถูกเรียกจากคลาสลูก
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Abstract Method ที่บังคับให้คลาสลูกต้อง implement
        public abstract void StartEngine();
        public abstract void StopEngine();

        // เมธอดปกติที่มีโค้ดการทำงานอยู่แล้ว
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }
}
