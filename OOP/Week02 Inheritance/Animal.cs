using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Animal
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public int Age { get; set; }

        // Constructor ของ Base Class
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            Health = 100.0f; // เริ่มต้นสุขภาพที่ 100
            Console.WriteLine($"A new animal named {Name} was created.");
        }

        public void Eat(string food) // เมธอดที่คลาสลูกจะสืบทอดไป
        {
            Console.WriteLine($"{Name} is eating {food}.");
            Health = Math.Min(Health + 10.0f, 100.0f); // กินแล้วสุขภาพเพิ่มขึ้น แต่ไม่เกิน 100
        }

        // เมธอดนี้จะให้คลาสลูกไปเขียนรายละเอียดการส่งเสียงเอง
        // ใช้ virtual เพื่อให้คลาสลูกสามารถ Override ได้
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a generic sound.");
        }
    }
}
