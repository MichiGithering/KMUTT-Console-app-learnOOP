using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week05_Abstract
{
    internal class Burger : Food
    {
        public bool HasCheese { get; set; }

        // เรียกคอนสตรักเตอร์ของคลาสแม่
        public Burger(bool hasCheese, double calories) : base("Burger", calories)
        {
            HasCheese = hasCheese;
        }

        // Override เมธอด Prepare() และ Eat()
        public override void Prepare()
        {
            string cheeseStatus = HasCheese ? "with cheese" : "without cheese";
            Console.WriteLine($"Assembling a Burger {cheeseStatus}.");
            Console.WriteLine("Patty is grilled, and buns are toasted.");
        }

        public override void Eat()
        {
            Console.WriteLine("Taking a big bite of the burger!");
        }
    }
}
