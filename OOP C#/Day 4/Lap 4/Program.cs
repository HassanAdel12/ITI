using System;

namespace Lap_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Complex
            Complex c1 = new Complex();
            Complex c2 = new Complex(0, -10);
            Complex c3 = new Complex(-1);

            c1.Print();
            c2.Print();
            c3.Print();

            Complex c4 = new Complex();

            c4.SetImg();
            c4.SetReal();
            c4.Print();

            c3 = c1.Add(c2);
            c3.Print();
            c3 = c2.Add(c1);
            c3.Print();

            Console.WriteLine(Complex.GetCounter());
            #endregion

            #region operator for two numbers
            //double num1, num2;
            //char ch, oper;

            //do
            //{

            //    Console.WriteLine("Enter frist number :");
            //    num1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter second number :");
            //    num2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter operator :");
            //    oper = char.Parse(Console.ReadLine());

            //    switch (oper)
            //    {
            //        case '+':
            //            Console.WriteLine($"{num1} + {num2} = {MyMath.sum(num1, num2)}");
            //            break;
            //        case '-':
            //            Console.WriteLine($"{num1} - {num2} = {MyMath.sub(num1, num2)}");
            //            break;
            //        case '*':
            //            Console.WriteLine($"{num1} * {num2} = {MyMath.mul(num1, num2)}");
            //            break;
            //        case '/':
            //            if (num2 != 0.0)
            //            {
            //                Console.WriteLine($"{num1} / {num2} = {MyMath.div(num1, num2)}");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"runtime error");
            //            }
            //            break;
            //        case '%':
            //            if (num2 != 0.0)
            //            {
            //                Console.WriteLine($"{num1} % {num2} = {MyMath.rem(num1, num2)}");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"runtime error");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("operator isnot find");
            //            break;
            //    }

            //    Console.WriteLine("Continue y or n");
            //    ch = char.Parse(Console.ReadLine());

            //} while (ch == 'y');

            #endregion


        }
    }
}
