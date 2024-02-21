using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_6
{
    class Rectangle : Geoshape
    {
        public Rectangle()
        {
        }

        public Rectangle(double _d1, double _d2) : base(_d1, _d2)
        {
        }

        public override double CArea()
        {
            return dim1 * dim2;
        }

        public override void Show()
        {
            Console.WriteLine("I'm Rectangle");
        }
    }
}
