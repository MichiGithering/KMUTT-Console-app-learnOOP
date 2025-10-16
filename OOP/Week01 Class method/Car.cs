using System;

namespace OOP
{
    public class Car
    {
        // Properties (คุณสมบัติของรถยนต์)
        public string Make { get; set; }    // ยี่ห้อรถ
        public string Model { get; set; }   // รุ่นรถ
        public string Color { get; set; }   // สีรถ
        public int Year { get; set; }       // ปีที่ผลิต
        public int CurrentSpeed { get; private set; } // ความเร็วปัจจุบัน (ตั้งค่าได้เฉพาะภายใน Class)
        public bool IsEngineRunning { get; private set; } // สถานะเครื่องยนต์ (ติด/ดับ)

        // Constructor (ตัวสร้าง) - ใช้สำหรับสร้าง Object ของ Car
        // จะถูกเรียกเมื่อเราสร้าง Object ใหม่ (e.g., new Car(...))
        public Car(string make, string model, string color, int year)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            CurrentSpeed = 0;           // เริ่มต้นความเร็วเป็น 0
            IsEngineRunning = false;    // เริ่มต้นเครื่องยนต์ยังไม่ติด
            Console.WriteLine($"A {Color} {Year} {Make} {Model} has been created.");
        }

        // Methods (พฤติกรรมหรือการกระทำที่รถยนต์สามารถทำได้)

        // Method: StartEngine - สตาร์ทเครื่องยนต์
        public void StartEngine()
        {
            if (!IsEngineRunning) // ถ้าเครื่องยนต์ยังไม่ติด
            {
                IsEngineRunning = true;
                Console.WriteLine($"{Make} {Model}'s engine is now running.");
            }
            else
            {
                Console.WriteLine($"{Make} {Model}'s engine is already running.");
            }
        }

        // Method: StopEngine - ดับเครื่องยนต์
        public void StopEngine()
        {
            if (IsEngineRunning) // ถ้าเครื่องยนต์กำลังติด
            {
                if (CurrentSpeed == 0) // ดับเครื่องได้เมื่อรถจอดสนิท
                {
                    IsEngineRunning = false;
                    Console.WriteLine($"{Make} {Model}'s engine has been stopped.");
                }
                else
                {
                    Console.WriteLine($"Cannot stop {Make} {Model}'s engine while driving. Please brake first.");
                }
            }
            else
            {
                Console.WriteLine($"{Make} {Model}'s engine is already off.");
            }
        }

        // Method: Accelerate - เร่งความเร็ว
        public void Accelerate(int speedIncrease)
        {
            if (IsEngineRunning) // ต้องสตาร์ทเครื่องก่อนถึงจะเร่งได้
            {
                if (speedIncrease > 0)
                {
                    CurrentSpeed += speedIncrease;
                    Console.WriteLine($"{Make} {Model} is accelerating. Current speed: {CurrentSpeed} km/h.");
                }
                else
                {
                    Console.WriteLine("Acceleration amount must be positive.");
                }
            }
            else
            {
                Console.WriteLine($"Cannot accelerate. {Make} {Model}'s engine is off. Please start the engine first.");
            }
        }

        // Method: Brake - เบรก
        public void Brake(int speedDecrease)
        {
            if (IsEngineRunning) // ต้องสตาร์ทเครื่องก่อนถึงจะเบรกได้ (กรณีเบรกขณะขับ)
            {
                if (speedDecrease > 0)
                {
                    CurrentSpeed -= speedDecrease;
                    if (CurrentSpeed < 0) CurrentSpeed = 0; // ความเร็วต้องไม่ติดลบ
                    Console.WriteLine($"{Make} {Model} is braking. Current speed: {CurrentSpeed} km/h.");
                }
                else
                {
                    Console.WriteLine("Brake amount must be positive.");
                }
            }
            else
            {
                Console.WriteLine($"Brake applied to {Make} {Model}. Current speed: {CurrentSpeed} km/h."); // สามารถเบรกได้แม้เครื่องดับ (รถจอดอยู่)
            }
        }

        // Method: DisplayCarInfo - แสดงข้อมูลรถยนต์
        public void DisplayCarInfo()
        {
            Console.WriteLine($"\n--- Car Information ---");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Current Speed: {CurrentSpeed} km/h");
            Console.WriteLine($"Engine Status: {(IsEngineRunning ? "Running" : "Off")}");
            Console.WriteLine($"-----------------------");
        }
    }
}
