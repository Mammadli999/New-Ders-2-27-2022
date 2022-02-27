using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOP.Abstraction
{
    internal class Phone : ICalculator,IAlarmClock
    {
        public void Call(string PhoneNumber)
        {
            Console.WriteLine($"Call to {PhoneNumber}...");
        }
        public void Start()
        {
            Console.WriteLine($"Call Accepted!");
        }

        public void Alarm()
        {
            Console.WriteLine("");
        }

        public void End()
        {
            Console.WriteLine($"Call Ended!");
        }

        public double Calculate()
        {
            Console.WriteLine("Calculate with Phone");
            return 0;
        }

        public double Sqrt()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
