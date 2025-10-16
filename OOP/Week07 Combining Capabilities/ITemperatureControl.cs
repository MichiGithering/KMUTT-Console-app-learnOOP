using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface.Electrical
{
    internal interface ITemperatureControl
    {
        // Property สำหรับตั้ง/อ่านอุณหภูมิเป้าหมาย
        int TargetTemperature { get; set; }

        // Property สำหรับอ่านอุณหภูมิที่วัดได้
        int CurrentTemperature { get; }

        // Property สำหรับอ่านขีดจำกัด
        int MinTemperature { get; }
        int MaxTemperature { get; }
        void SetTemperature(int degrees);
        int GetCurrentTemperature();
    }
}
