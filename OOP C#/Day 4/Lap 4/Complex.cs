using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_4
{
    class Complex
    {
        #region Fields

        int real;
        int img;
        static int counter = 0;

        #endregion

        #region Static getter for counter
        public static int GetCounter()
        {
            return counter;
        }
        #endregion

        #region Setters & Getters

        public void SetReal(int _real = 1) { this.real = _real; }
        public void SetImg(int _img = 1) { this.img = _img; }
        public int GetReal() { return this.real; }
        public int GetImg() { return this.img; }

        #endregion

        #region Print
        public void Print()
        {
            switch (this.img )
            {
                case 0:
                    if(this.real != 0)
                    {
                        Console.WriteLine($"{this.real}");
                    }
                    else
                    {
                        Console.WriteLine($"");
                    }
                    break;
                case 1:
                    if (this.real != 0)
                    {
                        Console.WriteLine($"{this.real} + i");
                    }
                    else
                    {
                        Console.WriteLine($"i");
                    }
                    
                    break;
                case -1:
                    if (this.real != 0)
                    {
                        Console.WriteLine($"{this.real} - i");
                    }
                    else
                    {
                        Console.WriteLine($"- i");
                    }
                    
                    break;
                case < -1:
                    if (this.real != 0)
                    {
                        Console.WriteLine($"{this.real} - {this.img * -1}i");
                    }
                    else
                    {
                        Console.WriteLine($"- {this.img * -1}i");
                    }
                    
                    break;
                
                default:
                    if (this.real != 0)
                    {
                        Console.WriteLine($"{this.real} + {this.img}i");
                    }
                    else
                    {
                        Console.WriteLine($"{this.img}i");
                    }
                    
                    break;
            }
            
        }
        #endregion

        #region Function To Add Two Complex Numbers

        public Complex Add(Complex right)
        {
            Complex tmp = new Complex();
            tmp.real = this.real + right.real;
            tmp.img = this.img + right.img;
            return tmp;
        }
        #endregion

        #region Constructor/s

        public Complex()
        {
            counter++;
            real = 3;
            img = 4;
        }
        public Complex(int _real, int _img)
        {
            counter++;
            real = _real;
            img = _img;
        }
        public Complex(int _num)
        {
            counter++;
            real = img = _num;
        }
        #endregion
    }
}
