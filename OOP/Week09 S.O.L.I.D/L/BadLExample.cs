using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.L
{
    internal class BadLExample
    {
        public class Bird // คลาสแม่: นก
        {
            public virtual void Fly()
            {
                Console.WriteLine("Bird is flying.");
            }

            public virtual void LayEggs()
            {
                Console.WriteLine("Bird is laying eggs.");
            }
        }

        public class Ostrich : Bird // นกกระจอกเทศเป็นนก แต่บินไม่ได้
        {
            public override void Fly()
            {
                // ปัญหา: นกกระจอกเทศบินไม่ได้ แต่ต้อง implement เมธอดนี้
                // อาจจะโยน Exception หรือทำอะไรที่ผิดปกติ
                throw new InvalidOperationException("Ostrich cannot fly!");
                // Console.WriteLine("Ostrich waddles instead of flying.");
            }
        }

        public class BirdHandler
        {
            public void MakeBirdFly(Bird bird)
            {
                bird.Fly(); // ถ้าส่ง Ostrich มาตรงนี้จะพัง
            }
        }
    }
    
}
