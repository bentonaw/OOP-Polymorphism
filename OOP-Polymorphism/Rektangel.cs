using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Rektangel : Geometri
    {
        internal double Length { get; set; }
        internal double Width { get; set; }
        public Rektangel()
        {
            Length = 4.0;
            Width = 3.0;
        }
        internal override double Area()
        {
            return Length * Width;
        }
    }
}
