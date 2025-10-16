using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface
{
    internal class PushNotificationService : INotifiable
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
            // โค้ดจริงสำหรับการส่ง Push Notification
        }
    }
}
