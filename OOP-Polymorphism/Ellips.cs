using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        internal double Horizontal {  get; set; }
        internal double Vertical { get; set; }
        public Ellips()
        {
            Horizontal = 7.0;
            Vertical = 8.0;
        }
        internal override double Area()
        {
            return Math.PI * Horizontal * Vertical;
        }
    }
}
