using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Cat : Animal // Cat สืบทอดจาก Animal
    {
        public string FurType { get; set; }

        public Cat(string name, int age, string furType) : base(name, age)
        {
            FurType = furType;
            Console.WriteLine($"A {FurType} cat was created.");
        }

        // Override เมธอด MakeSound() เพื่อให้มีพฤติกรรมเฉพาะของแมว
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }

        // เมธอดเฉพาะของ Cat
        public void Groom()
        {
            Console.WriteLine($"{Name} is grooming itself.");
        }
    }
}
