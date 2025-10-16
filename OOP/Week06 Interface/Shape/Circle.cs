using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface
{
    internal class Circle : I2DShape
    {
        public string Name => "Circle";

        public double Radius { get; set; }


        // ต้องเพิ่มคุณสมบัติ Color
        public string Color { get; set; }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        // สร้างเมธอด Draw()
        public void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Circle with radius {Radius}.");
        }

        // สร้างเมธอด CalculateArea()
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        // สร้างเมธอด PrintDetails() ตามที่ IShape กำหนด
        public void PrintDetails()
        {
            Console.WriteLine($"Shape: Circle");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
        }
    }
}
