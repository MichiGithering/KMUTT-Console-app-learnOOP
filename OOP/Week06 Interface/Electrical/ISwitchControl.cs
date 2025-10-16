using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week06_Interface.Electrical
{
    internal interface ISwitchControl 
    {
        bool isOn { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
