using System;
using System.Threading;

namespace ConsoleApp.OOP.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();

            phone.Calculate();

        }

        static void AlarmDuringFiveMinute(IAlarmClock device)
        {
            device.Alarm();
            Thread.Sleep(5000);
            device.Stop();
        }

        static void CalculateMonthly(ICalculator device)
        {
            device.Calculate();
            device.Sqrt();
        }
    }
}
