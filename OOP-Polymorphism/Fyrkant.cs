using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        internal double Length { get; set; }
        public Fyrkant()
        {
            Length = 4.0;
        }
        internal override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
