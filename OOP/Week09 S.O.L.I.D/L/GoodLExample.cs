using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.L
{
    internal class GoodLExample
    {
        public class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("Animal is eating");
            }
            public class Bird : Animal
            {
                public virtual void LayEggs(string name)
                {
                    Console.WriteLine($"{name} has lay eggs");
                }
            }

            public interface IFlyable
            {
                void Fly();
            }

            public class Eagle : Bird, IFlyable
            {
                public string Naname = "Eagle";
                public void Fly()
                {
                    Console.WriteLine("Eagle rise to the sky");
                }
                public override void Eat()
                {
                    Console.WriteLine("The Eagle consumed it's prey.");
                }

                public override void LayEggs(string name)
                {
                    base.LayEggs(name);
                }
            }

            public class Penguin : Bird
            {
                public override void Eat()
                {
                    Console.WriteLine("Penguin eat fish :D");
                }
        }
    }
}
