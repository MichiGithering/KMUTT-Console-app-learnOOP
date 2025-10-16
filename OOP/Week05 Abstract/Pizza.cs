using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week05_Abstract
{
    internal class Pizza : Food
    {
        public string Size { get; set; } // Small, Medium, Large
        public List<string> Toppings { get; set; }
        public Pizza(string name, double calories, string size, List<string> toppings)
            : base(name, calories) // เรียกคอนสตรักเตอร์ของคลาสแม่
        {
            Size = size;
            Toppings = toppings;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing a {Size} pizza named {Name} with toppings: {string.Join(", ", Toppings)}.");
            // โค้ดการเตรียมแป้ง, ซอส, ชีส, และท็อปปิ้งต่างๆ
        }
        public override void Eat()
        {
            Console.WriteLine($"Eating the delicious {Name} pizza!");
            // โค้ดการกินพิซซ่า
        }
    }
}
