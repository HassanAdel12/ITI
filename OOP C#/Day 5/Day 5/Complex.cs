using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Complex
    {
        #region Fields
        int real;
        int img;
        #endregion

        #region Print
        public void Print()
        {
            Console.WriteLine($"{real}+{this.img}i");
        }
        #endregion

        #region Constructor

        public Complex()
        {
            real = 3;
            img = 4;
        }
        public Complex(int _real, int _img)
        {
            real = _real;
            img = _img;
        }
        public Complex(int _num)
        {
            real = img = _num;
        }
        #endregion

        #region Operators
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex(left.real + right.real, left.img + right.img);
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex(left.real - right.real, left.img - right.img);
        }

        public static Complex operator ++(Complex left)
        {
            return new Complex(left.real + 1, left.img);
        }

        public static implicit operator int(Complex left)
        {
            return left.real;
        }

        public static bool operator >(Complex left, Complex right)
        {
            return right.real > left.real && right.img > left.img;
        }
        public static bool operator <(Complex left, Complex right)
        {
            return right.real < left.real && right.img < left.img;
        }
        
        #endregion
    }
}
