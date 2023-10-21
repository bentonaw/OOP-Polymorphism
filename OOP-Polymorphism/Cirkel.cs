using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Cirkel : Geometri
    {
        internal double Radius { get; set; }

        public Cirkel()
        {
            Radius = 4;
        }
        internal override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
