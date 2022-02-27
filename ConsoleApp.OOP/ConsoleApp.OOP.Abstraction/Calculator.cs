using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOP.Abstraction
{
   internal class Calculator : ICalculator
    {
        public double Sqrt()
        {
            throw new NotImplementedException();
        }

        double ICalculator.Calculate()
        {
            throw new NotImplementedException();
        }

        internal void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
