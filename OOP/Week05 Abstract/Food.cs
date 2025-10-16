using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week05_Abstract
{
    internal abstract class Food
    {
        // คุณสมบัติที่อาหารทุกชนิดมี
        public string Name { get; set; }
        public double Calories { get; set; }

        // คอนสตรักเตอร์สำหรับคลาสแม่
        public Food(string name, double calories)
        {
            Name = name;
            Calories = calories;
        }

        // Abstract Method: พฤติกรรมที่ต้องให้คลาสลูกเขียนโค้ดเอง
        // นี่คือ "สัญญา" ว่าอาหารทุกชนิดต้องมีวิธีเตรียมและรับประทาน
        public abstract void Prepare();
        public abstract void Eat();

        // เมธอดปกติที่มีโค้ดการทำงานอยู่แล้ว
        public void DisplayInfo()
        {
            Console.WriteLine($"--- Food Info ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Calories: {Calories} kcal");
        }

    }
}
