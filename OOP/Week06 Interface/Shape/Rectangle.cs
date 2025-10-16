using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface
{
    internal class Rectangle : I2DShape
    {
        public string Name { get; } = "Rectangle";

        public double Width { get; set; }
        public double Height { get; set; }

        // ต้องเพิ่มคุณสมบัติ Color
        public string Color { get; set; }


        public Rectangle(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        // สร้างเมธอด Draw()
        public void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Rectangle with width {Width} and height {Height}.");
        }

        // สร้างเมธอด CalculateArea()
        public double CalculateArea()
        {
            return Width * Height;
        }

        // สร้างเมธอด PrintDetails() ตามที่ IShape กำหนด
        public void PrintDetails()
        {
            Console.WriteLine($"Shape: Rectangle");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Dimensions: {Width} x {Height}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
        }
    }
}
