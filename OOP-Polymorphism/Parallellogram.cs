using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Parallellogram : Geometri
    {
        internal double Height { get; set; }
        internal double Base { get; set; }
        public Parallellogram()
        {
            Height = 5.0;
            Base = 6.0;
        }

        internal override double Area()
        {
            return Height * Base;
        }
    }
}
