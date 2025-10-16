using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface.Electrical
{
    internal class AirConditioner : ISwitchControl, ITemperatureControl
    {
        // --- Fields and Constants ---
        private bool _isOn = false;
        private int _targetTemp = 25;
        private int _currentTemp = 30;

        // Property จาก IPowerControl
        //1. Full-Body Get/Set Accessor (รูปแบบดั้งเดิม)
        public bool isOn { get { return _isOn; } set { _isOn = value; } }
        //2. Expression-Bodied Get/Set (รูปแบบย่อด้วย =>)
        public int TargetTemperature { get => _targetTemp; set => _targetTemp = value; }
        //3. Read-Only
        //3.1 Read-Only Expression
        public int CurrentTemperature => _currentTemp;
        //3.2 Read-Only Full

        public readonly int _MinTemperature = 16;//ค่าคงที่ ไม่สามารถถูกเปลี่ยนแปลงได้เลยตลอดอายุการทำงาน 
        public readonly int _MaxTemperature;//ค่าคงที่ ไม่สามารถถูกเปลี่ยนแปลงได้เลยตลอดอายุการทำงาน

        public AirConditioner(int fluctuation) {
            _MaxTemperature = 30 + fluctuation;//
        }
        public int MinTemperature => _MinTemperature;
        //4. Auto-Implemented Property (รูปแบบสั้นที่สุด)
        public int MaxTemperature => _MaxTemperature;

        // --- IPowerControl Methods ---

        public void TurnOff()
        {
            ToggleSwitch();
        }

        public void TurnOn()
        {
            ToggleSwitch();
        }
        void ToggleSwitch()
        {
            isOn = !isOn;
            string result = isOn ? "ON" : "OFF";
            Console.WriteLine($"Air Conditioner toggled to: {result}");
        }

        // --- ITemperatureControl Methods ---

        public void SetTemperature(int degrees)
        {
            if (isOn)
            {
                // ใช้ Math.Max และ Math.Min ในการจำกัดค่า (Clamping)
                _targetTemp = Math.Max(MinTemperature, Math.Min(degrees, MaxTemperature));

                Console.WriteLine($"Target temperature set to: {_targetTemp}°C");
            }
            else
            {
                Console.WriteLine("Cannot set temperature; AC is OFF.");
            }
        }

        public int GetCurrentTemperature()
        {
            // จำลองการปรับอุณหภูมิเข้าหาเป้าหมาย
            if (isOn)
            {
                if (_currentTemp > _targetTemp)
                    _currentTemp--;
                else if (_currentTemp < _targetTemp)
                    _currentTemp++;
            }
            return _currentTemp;
        }

       
    }

}
