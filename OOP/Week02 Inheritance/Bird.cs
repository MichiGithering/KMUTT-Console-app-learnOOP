using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal class Bird : Animal
    {
        public string FeatherColor { get; set; }

        public Bird(string name, int age, string featherColor) : base(name, age)
        {
            FeatherColor = featherColor;
            Console.WriteLine($"A {FeatherColor} bird was created.");
        }

        // Override เมธอด MakeSound() เพื่อให้มีพฤติกรรมเฉพาะของนก
        public override void MakeSound()
        {
            Console.WriteLine("Chirp! Chirp!");
        }

        // เมธอดเฉพาะของ Bird
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying high in the sky!");
        }
    }
}
