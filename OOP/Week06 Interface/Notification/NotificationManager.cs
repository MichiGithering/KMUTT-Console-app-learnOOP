using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface
{
    internal class NotificationManager
    {
        // เมธอดนี้รับอ็อบเจกต์อะไรก็ได้ที่ทำตามสัญญา INotifiable
        public void NotifyUser(INotifiable service, string message)
        {
            Console.WriteLine("Preparing to send notification...");
            service.SendMessage(message);
            Console.WriteLine("Notification sent successfully.");
        }
    }
}
