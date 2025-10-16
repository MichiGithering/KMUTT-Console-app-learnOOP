using System;

namespace OOP
{
    public class Student
    {
        // Properties (คุณสมบัติของนักเรียน)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        // Constructor (ตัวสร้าง) - ใช้สำหรับสร้าง Object จาก Class
        // มันจะถูกเรียกเมื่อเราสร้าง Object ใหม่ (e.g., new Student())
        public Student(string firstName, string lastName, int age, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            GPA = gpa;
        }

        // Methods (พฤติกรรมหรือการกระทำที่นักเรียนสามารถทำได้)
        public void Study()
        {
            Console.WriteLine($"{FirstName} {LastName} is studying hard!");
        }

        public void AttendActivity(string activityName)
        {
            Console.WriteLine($"{FirstName} {LastName} is attending {activityName}.");
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"\n--- Student Information ---");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"GPA: {GPA:F2}"); // F2 คือการจัดรูปแบบทศนิยม 2 ตำแหน่ง
            Console.WriteLine($"---------------------------");
        }
    }
}