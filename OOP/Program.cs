using OOP.Week05_Abstract;
using OOP.Week06_Interface;
using OOP.Week06_Interface.Electrical;
using OOP.Week07_Combining_Capabilities;
using OOP.Week08_Static;
using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create Sheep instances
            // 1. การเข้าถึง Static Property (จะทำให้ Static Constructor ของ Sheep ทำงานก่อน)
            Console.WriteLine($"Initial Check - Sheep Count: {Sheep.TotalSheepCount}");

            // 2. สร้าง Instance ของ Sheep
            Console.WriteLine("\n--- Creating Sheep Instances ---");
            Sheep alfred = new Sheep(1);
            Sheep bob = new Sheep(2);
            Sheep clara = new Sheep(3);
            Sheep dave = new Sheep(4);

            // check total number of sheep
            // note that this is a class method, not an object method.
            Console.WriteLine("Total number of sheep is " + Sheep.TotalSheepCount);

            // check which pen dave is in then move him to another pen
            Console.WriteLine("dave is in pen " + dave.AskNumber());
            dave.SetNumber(5);
            Console.WriteLine("moving dave ...");
            Console.WriteLine("dave is now in pen " + dave.AskNumber());

            // 3. เข้าถึง const โดยใช้ชื่อ Static Class
            Console.WriteLine($"Accessing const directly: The farm has {FarmUtils.DefaultPens} default pens.");

            // 4. เรียกใช้ Static Class Methods
            FarmUtils.DisplayCurrentStatus();

            // 5. เรียกใช้ Static Method และดูผลกระทบต่อ Static Property
            Sheep.RemoveSheep(1);
            FarmUtils.DisplayCurrentStatus();
        }

        private static void Static()
        {
            // 1. เรียกใช้ Static Class & Members
            Console.WriteLine($"Pi value from Static Class: {Constants.PiValue}");
            Console.WriteLine($"Max value: {Constants.GetMax(10, 20)}");

            Console.WriteLine("\n--- Creating AppCounter Instances ---");

            // 2. สร้างออบเจกต์ AppCounter (จะเรียก Static Constructor ก่อน)
            AppCounter counter1 = new AppCounter();
            AppCounter counter2 = new AppCounter();

            // 3. เข้าถึง Static Property โดยใช้ชื่อคลาส
            Console.WriteLine($"Total Instances (via Static Property): {AppCounter.InstanceCount}");

            // 4. เรียกใช้ Static Method
            AppCounter.ResetCounter();

            // 5. สร้างออบเจกต์ใหม่หลังจาก Reset
            AppCounter counter3 = new AppCounter();
        }

        private static void PrintElectronic()
        {
            // 1. ตัวอย่างการใช้ Polymorphism ผ่าน ISwitchControl
            // สร้าง List ของอุปกรณ์ที่สามารถเปิด/ปิดได้
            LightBulb lightBulb = new LightBulb();
            lightBulb.TurnOn();
            lightBulb.TurnOff();
            Console.WriteLine(lightBulb.isOn);

            PortableFan fan = new PortableFan();
            fan.TurnOn();
            fan.TurnOn();
            fan.TurnOff();
            Console.WriteLine(fan.isOn);


            List<ISwitchControl> smarthome = new List<ISwitchControl>();

            // เพิ่ม AirConditioner และ lightBulb เข้าไปใน List (ใช้ Reference เป็น ISwitchControl)
            smarthome.Add(lightBulb);
            smarthome.Add(fan);

            Console.WriteLine("--- 1. การทำงานร่วมกันผ่าน ISwitchControl (เปิด/ปิด) ---");

            foreach (var device in smarthome)
            {
                // สามารถเรียกใช้ TurnOn ได้กับทุก Object ใน List
                device.TurnOn();
            }

            Console.WriteLine("\n--- สั่งปิดทั้งหมด ---");
            foreach (var device in smarthome)
            {
                device.TurnOff();
            }

            Console.WriteLine("\n======================================================\n");


            // 2. ตัวอย่างการใช้ Polymorphism ผ่าน ITemperatureControl
            // สร้าง List ของอุปกรณ์ที่สามารถควบคุมอุณหภูมิได้
            List<ITemperatureControl> temperatureControllers = new List<ITemperatureControl>();

            // สร้าง Object ที่ Implement ITemperatureControl
            AirConditioner air = new AirConditioner(5); // AirConditioner implements ISwitchControl and ITemperatureControl
            Fridge fridge = new Fridge(); // Fridge implements ITemperatureControl

            temperatureControllers.Add(air);
            temperatureControllers.Add(fridge);

            Console.WriteLine("--- 2. การทำงานร่วมกันผ่าน ITemperatureControl (ตั้งค่าอุณหภูมิ) ---");

            // สั่งเปิด AC ก่อน เพราะมัน Implement ISwitchControl ด้วย
            air.TurnOn();

            Console.WriteLine("Fridge CurrentTemperture is : " + fridge.CurrentTemperature);
            fridge.SetTemperature(15);

            while (fridge.CurrentTemperature != fridge.TargetTemperature)
            {
                fridge.GetCurrentTemperature();
            }
            Console.WriteLine("Fridge CurrentTemperture is : " + fridge.CurrentTemperature);

            air.TurnOn();
            air.TurnOff();
            Console.WriteLine("Air is turn on :" + air.isOn);

            air.SetTemperature(25);
            while (air.CurrentTemperature != air.TargetTemperature)
            {
                air.GetCurrentTemperature();
            }

            smarthome.Add(air);

            Console.WriteLine("--- 1.  ISwitchControl (off/on) ---");

            foreach (var device in smarthome)
            {
                // สามารถเรียกใช้ TurnOn ได้กับทุก Object ใน List
                device.TurnOn();
            }

            Console.WriteLine("\n--- turn off ---");
            foreach (var device in smarthome)
            {
                device.TurnOff();
            }

            List<ITemperatureControl> SmartTempatureControl = new List<ITemperatureControl>();

            fridge.SetTemperature(9);
            air.SetTemperature(15);
            SmartTempatureControl.Add(fridge);
            SmartTempatureControl.Add(air);

            foreach (var device in SmartTempatureControl)
            {
                while (device.CurrentTemperature != device.TargetTemperature)
                {
                    device.GetCurrentTemperature();
                }
            }
        }

        private static void PrintFood()
        {
            // สร้างลิสต์ของ Food
            List<Food> Order = new List<Food>();
            // เพิ่ม Pizza และ Burger เข้าไปในลิสต์
            //Food food = new Food(); ไม่สามารถสร้าง object ของคลาส Food ได้โดยตรง เพราะเป็นคลาส abstract

            Order.Add(new Burger(true, 550));
            List<string> pizzaToppings = new List<string> { "Pepperoni", "Mushrooms", "Onions" };
            Order.Add(new Pizza("Pepperoni", 600, "L", pizzaToppings));

            // วนลูปเพื่อจัดการกับอาหารแต่ละชนิด
            foreach (Food item in Order)
            {
                item.DisplayInfo();
                item.Prepare();
                item.Eat();
                Console.WriteLine();
            }
        }

        private static void PrintSmatchPhone() {
            // สร้างออบเจกต์ SmartPhone
            SmartPhone myPhone = new SmartPhone("AlphaPhone 10");

            // เรียกใช้เมธอดทั้งหมดจากออบเจกต์ SmartPhone
            Console.WriteLine("--- Testing SmartPhone functionalities ---");
            myPhone.MakeCall("081-123-4567");
            myPhone.EndCall();
            myPhone.TakePhoto();
            myPhone.RecordVideo();

            Console.WriteLine();

            // เราสามารถอ้างอิงถึงออบเจกต์ SmartPhone ผ่าน Interface ได้
            ICallable phoneForCall = myPhone;
            phoneForCall.MakeCall("092-765-4321");

            ICamera phoneForCamera = myPhone;
            phoneForCamera.TakePhoto();

            // หมายเหตุ: ตัวแปร phoneForCall ไม่สามารถเข้าถึงเมธอดของ ICamera ได้
            // และ phoneForCamera ก็ไม่สามารถเข้าถึงเมธอดของ ICallable ได้
            // นี่คือข้อดีของการใช้ Interfaces เพื่อจำกัดการเข้าถึง
            // phoneForCall.TakePhoto(); // จะเกิด Compile Error
        }
        private static void PrintAnimalSound() {
            NotificationManager manager = new NotificationManager();

            // ส่ง SMS
            INotifiable sms = new SmsService();
            manager.NotifyUser(sms, "Your order has been shipped!");
            // ผลลัพธ์:
            // Preparing to send notification...
            // Sending SMS: Your order has been shipped!
            // Notification sent successfully.

            Console.WriteLine("--------------------");

            // ส่ง Email
            INotifiable email = new EmailService();
            manager.NotifyUser(email, "Your new password is '1234'.");
            // ผลลัพธ์:
            // Preparing to send notification...
            // Sending Email: Your new password is '1234'.
            // Notification sent successfully.
        }
        private static void PrintShape() {
            List<I2DShape> shapes = new List<I2DShape>();

            shapes.Add(new Circle(5, "Red"));
            shapes.Add(new Rectangle(4, 6, "Blue"));

            // ถ้าเรามีคลาส Triangle เราก็สามารถเพิ่มได้
            // shapes.Add(new Triangle(10, 8, "Green"));

            // วนลูปเพื่อจัดการกับรูปทรงทั้งหมด
            foreach (I2DShape shape in shapes)
            {
                // โค้ดส่วนนี้ยังคงเป็นนามธรรมสูง
                shape.PrintDetails(); // เรียกใช้เมธอดที่เพิ่มเข้ามา
                shape.Draw();
                Console.WriteLine();
            }
        }
        private static void PrintPerson()
        {
            Console.WriteLine("--- Creating a new Person object ---");
            // สร้าง Object ของ Person โดยใช้ constructor
            // ต้องใส่ค่า IdCardNumber และ HeightInMeters เข้าไป
            DateTime dateTime = new DateTime(1991, 1, 1);
            Person p1 = new Person("1103700012345", dateTime);

            // 1. Auto-Implemented Property: FirstName, LastName
            // ตั้งค่าชื่อและนามสกุล
            p1.FirstName = "John";
            p1.LastName = "Doe";


            Console.WriteLine($"Name set to: {p1.FirstName} {p1.LastName}");

            Console.WriteLine("--- Setting Properties ---");
            // 2. Full Property: HeartRate
            // ตั้งค่าอายุที่ถูกต้อง
            p1.HeartRate = 60;
            Console.WriteLine($"HeartRate set successfully: {p1.HeartRate}");
            // ลองตั้งค่าอายุที่ผิดพลาด (จะแสดงข้อความเตือน)
            p1.HeartRate = -5;

            // 3. Read-Only Properties: IdCardNumber, HeightInMeters, Bmi
            // IdCardNumber และ HeightInMeters ถูกตั้งค่าตอนสร้าง Object แล้ว
            Console.WriteLine($"--- Accessing Read-Only Properties ---");
            Console.WriteLine($"ID Card Number: {p1.IdCardNumber}");
            Console.WriteLine($"Age: {p1.Age:F2} m");

            // กำหนดค่า WeightInKg เพื่อให้ Bmi คำนวณได้
            p1.HeightInMeters = 1.75;
            p1.WeightInKg = 70.0;

            Console.WriteLine($"Weight: {p1.WeightInKg:F1} kg");
            // Bmi เป็น Read-Only และคำนวณจากค่า Weight และ Height
            Console.WriteLine($"BMI: {p1.Bmi:F2}");

            // ลองพยายามแก้ไขค่า Read-Only (จะเกิด Compile Error)
            // p1.IdCardNumber = "9999999999999"; // ERROR!
            // p1.HeightInMeters = 1.80; // ERROR!

            // 4. Write-Only Property: Password
            Console.WriteLine("\n--- Setting Write-Only Property ---");
            // ตั้งค่ารหัสผ่านที่ถูกต้อง (ความยาว 8 ตัวอักษรขึ้นไป)
            p1.Password = "strong_password123";
            // ลองตั้งค่ารหัสผ่านที่สั้นเกินไป
            p1.Password = "short";

            // ลองพยายามอ่านค่ารหัสผ่านกลับมา (จะเกิด Compile Error)
            // string password = p1.Password; // ERROR!
        }

        private static void PrintBankId()
        {
            // สร้าง Object ของบัญชีออมทรัพย์
            SavingsAccount myAccount = new SavingsAccount("S-12345", "my_secret_pass", 1000m, "MainBranch", 0.05m);

            Console.WriteLine("\n--- Accessing from Main Method ---");

            // public: สามารถเข้าถึงได้
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            myAccount.Deposit(500m);

            // internal: สามารถเข้าถึงได้เพราะอยู่ใน Assembly เดียวกัน
            Console.WriteLine($"Branch ID: {myAccount.BranchId}");

            // protected: ไม่สามารถเข้าถึงได้จากภายนอก
            // myAccount._balance = 2000; // ERROR!
            // myAccount.Withdraw(100); // ERROR!

            // private: ไม่สามารถเข้าถึงได้จากภายนอก
            // myAccount._passwordHash = "new_pass"; // ERROR!
            // myAccount.VerifyPassword("password"); // ERROR!

            // เรียกเมธอดที่ใช้การห่อหุ้ม
            myAccount.WithdrawFunds(200m, "my_secret_pass");
            myAccount.WithdrawFunds(50m, "wrong_pass");

            myAccount.AddMonthlyInterest();
        }

        private static void PrintAnimal()
        {
            // สร้าง Object ของ Dog
            Dog myDog = new Dog("Buddy", 3, "Golden Retriever");
            myDog.Eat("meat");       // สืบทอดมาจาก Animal
            myDog.MakeSound(); // เมธอดที่ Override จาก Animal
            myDog.Fetch();     // เมธอดเฉพาะของ Dog

            Console.WriteLine("\n--------------------\n");

            // สร้าง Object ของ Cat
            Cat myCat = new Cat("Whiskers", 5, "Tabby");
            myCat.Eat("Fish");       // สืบทอดมาจาก Animal
            myCat.MakeSound(); // เมธอดที่ Override จาก Animal
            myCat.Groom();     // เมธอดเฉพาะของ Cat

            Console.WriteLine("\n--------------------\n");

            // สร้าง Object ของ Bird
            Bird myBird = new Bird("Tweety", 1, "Yellow");
            myBird.Eat("Seed");        // สืบทอดมาจาก Animal
            myBird.MakeSound();  // เมธอดที่ Override จาก Animal
            myBird.Fly();        // เมธอดเฉพาะของ Bird
        }

        static void PrintStudent() {
            // สร้าง Object ของนักเรียนคนแรก (จาก Class Student)
            // เราเรียก Constructor ของ Class Student ที่เรารับพารามิเตอร์
            Student student1 = new Student("Alice", "Smith", 18, 3.85);

            // สร้าง Object ของนักเรียนคนที่สอง
            Student student2 = new Student("Bob", "Johnson", 19, 3.20);

            // เรียกใช้ Method เพื่อแสดงข้อมูลนักเรียน
            Console.WriteLine("--- Student 1 ---");
            student1.DisplayStudentInfo();

            Console.WriteLine("\n--- Student 2 ---");
            student2.DisplayStudentInfo();

            // เรียกใช้ Method เพื่อให้นักเรียนทำกิจกรรม
            Console.WriteLine("\n--- Student Activities ---");
            student1.Study();
            student2.AttendActivity("Football Club");
            student1.AttendActivity("Debate Team");

            // ลองเปลี่ยน GPA ของนักเรียน
            student1.GPA = 3.95;
            Console.WriteLine($"\n{student1.FirstName}'s new GPA is: {student1.GPA:F2}");

            student1.DisplayStudentInfo(); // แสดงข้อมูลที่อัปเดตแล้ว
        }
        static void PrintCar() {
            Console.WriteLine("--- Creating Cars ---");
            // สร้าง Object ของรถยนต์คันแรก (จาก Class Car)
            Car myCar = new Car("Honda", "Civic", "Red", 2023);

            // สร้าง Object ของรถยนต์คันที่สอง
            Car friendsCar = new Car("Toyota", "Camry", "Blue", 2022);

            // แสดงข้อมูลรถยนต์แต่ละคัน
            myCar.DisplayCarInfo();
            friendsCar.DisplayCarInfo();

            Console.WriteLine("\n--- My Car's Actions ---");
            myCar.StartEngine();        // สตาร์ทเครื่องยนต์
            myCar.Accelerate(50);       // เร่งความเร็ว 50 km/h
            myCar.Accelerate(30);       // เร่งเพิ่มอีก 30 km/h
            myCar.Brake(20);            // เบรก 20 km/h
            myCar.DisplayCarInfo();     // แสดงสถานะปัจจุบัน

            myCar.StopEngine();         // ลองดับเครื่อง (ยังเร็วอยู่)
            myCar.Brake(60);            // เบรกจนความเร็วเป็น 0
            myCar.StopEngine();         // ดับเครื่องยนต์

            myCar.DisplayCarInfo();     // แสดงสถานะล่าสุด

            Console.WriteLine("\n--- Friend's Car's Actions ---");
            friendsCar.Accelerate(10);  // ลองเร่งโดยไม่สตาร์ทเครื่อง
            friendsCar.StartEngine();
            friendsCar.Accelerate(80);
            friendsCar.DisplayCarInfo();
            friendsCar.StopEngine(); // ลองดับเครื่องขณะวิ่ง

            Console.WriteLine("\n--- End of Program ---");
        }
    }
}
