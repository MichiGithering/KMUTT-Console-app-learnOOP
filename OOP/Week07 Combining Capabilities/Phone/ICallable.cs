using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week07_Combining_Capabilities
{
    internal interface ICallable
    {
        void MakeCall(string phoneNumber);
        void EndCall();
    }
}
