using System;

namespace OOP.Week09_S.O.L.I.D.I
{
    internal class GoodIExample
    {
        public interface IPhysical
        {
            void PhysicalAttack();
            void UseShield();
        }

        public interface IMagical
        {
            void CastSpell();
            void CheckMana();
        }

        public interface ISupport
        {
            void Heal();
            void ApplyBuff();
        }

       

        public class Monk : IPhysical, ISupport
        {
            public void ApplyBuff()
            {

            }

            public void Heal()
            {
                Console.WriteLine("HealSelf");
            }

            public void PhysicalAttack()
            {
                Console.WriteLine("AttackedWith Fist");

            }

            public void UseShield()
            {
                Console.WriteLine("Raise Guard");
            }
        }
    }
}
