using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface
{
    internal class SmsService : INotifiable
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
            // โค้ดจริงสำหรับการส่ง SMS
        }
    }
}
