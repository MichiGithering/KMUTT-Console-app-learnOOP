using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        // Constructor ของ Dog ต้องเรียก Constructor ของ Animal ด้วย 'base()'
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
            Console.WriteLine($"A {Breed} dog was created.");
        }

        // Override เมธอด MakeSound() เพื่อให้มีพฤติกรรมเฉพาะของสุนัข
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        // เมธอดเฉพาะของ Dog
        public void Fetch()
        {
            Console.WriteLine($"{Name} fetches a stick.");
        }
    }
}
