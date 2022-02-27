using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOP
{
    internal class Book
    {
        public string name;
        public string author;


        private double _price;
        public double Price {
            get
            {
                return _price;
            } 
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price Grather Than Zero ");
                }
                this._price = value;
            }
        }
    }
}
