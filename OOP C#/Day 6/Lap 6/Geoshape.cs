using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_6
{
    abstract class Geoshape
    {
        protected double dim1;
        protected double dim2;

        protected double Dim1
        {
            get
            {
                return dim1;
            }

            set
            {
                dim1 = value;
            }
        }
        protected double Dim2
        {
            get
            {
                return dim2;
            }

            set
            {
                dim2 = value;
            }
        }

        public Geoshape()
        {
            dim1 = dim2 = 0;
        }

        public Geoshape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }

        public abstract double CArea();

        public virtual void Show()
        {
            Console.WriteLine("I'm Geoshape");
        }
    }
}
