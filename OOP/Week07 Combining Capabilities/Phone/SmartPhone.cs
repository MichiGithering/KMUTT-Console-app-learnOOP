using OOP.Week07_Combining_Capabilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface
{
    internal class SmartPhone : ICallable, ICamera
    {
        public string Model { get; set; }

        public SmartPhone(string model)
        {
            Model = model;
        }

        // Implement เมธอดจาก ICallable
        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Making a call to {phoneNumber} from {Model}.");
        }

        public void EndCall()
        {
            Console.WriteLine("Call ended.");
        }

        // Implement เมธอดจาก ICamera
        public void TakePhoto()
        {
            Console.WriteLine($"Taking a photo with the {Model} camera.");
        }

        public void RecordVideo()
        {
            Console.WriteLine($"Recording a video with the {Model} camera.");
        }
    }
}
