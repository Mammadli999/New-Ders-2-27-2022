using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOP.Abstraction
{
    internal interface ICalculator
    {
        double Calculate();

        double Sqrt();
    }

    interface IAlarmClock
    {
        void Alarm();
        void Stop();
    }
}
