using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_6
{
    class Square : Rectangle
    {
        public Square()
        {
        }

        public Square(double _d) : base(_d, _d)
        {
        }

        public override void Show()
        {
            Console.WriteLine("I'm Square");
        }
    }
}
