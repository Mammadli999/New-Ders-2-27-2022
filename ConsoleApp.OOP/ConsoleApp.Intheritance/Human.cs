using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Intheritance
{
    internal abstract class Human
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public void Talk()
        {
            Console.WriteLine($"Talking With Another Human");
        }
    }
}
