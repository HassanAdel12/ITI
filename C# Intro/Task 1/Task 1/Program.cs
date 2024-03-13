using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Hello World");


            //Task 2

            Console.WriteLine("enter one char");
            char ch;
            char.TryParse(Console.ReadLine(), out ch);
            int ASCII = (int)ch;
            Console.WriteLine(ASCII);


            //Task 3

            Console.WriteLine("enter Two float number ");
            Console.WriteLine("Enter Number 1");
            float Num1;
            float.TryParse(Console.ReadLine(), out Num1);
            Console.WriteLine("Enter Number 2");
            float Num2;
            float.TryParse(Console.ReadLine(), out Num2);
            Console.WriteLine("Number 1 is " + Num1+ " Number 2 is " + Num2);


            //Task 4

            Console.WriteLine("enter Two integers number ");
            Console.WriteLine("Enter Number 1");
            int intnum1;
            int.TryParse(Console.ReadLine(), out intnum1);
            Console.WriteLine("Enter Number 2");
            int intnum2;
            int.TryParse(Console.ReadLine(), out intnum2);
            Console.WriteLine("Number 1 is " + intnum1 + " Number 2 is " + intnum2 +" sum is "+(intnum1+ intnum2));


            //Task 5


            Console.WriteLine("enter one number ");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine($"Hexadecimal value of {num} is {num:X}");


            //Task 6


            Console.WriteLine("enter dividend ");
            int dividend;
            int.TryParse(Console.ReadLine(), out dividend);
            Console.WriteLine("enter divisor ");
            int divisor;
            int.TryParse(Console.ReadLine(), out divisor);

            int quotient = dividend/divisor;
            int remainder = dividend%divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);


            //Task 7

            Console.WriteLine("enter one number ");
            int even = int.Parse(Console.ReadLine());

            if(even % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }



            //Task 8



            Console.WriteLine("enter Three number ");
            Console.WriteLine("Enter Number 1");
            int number1;
            int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter Number 2");
            int number2;
            int.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Enter Number 3");
            int number3;
            int.TryParse(Console.ReadLine(), out number3);

            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.WriteLine(number1);
                }
                else
                {
                    Console.WriteLine(number3);
                }
            }
            else if (number2 > number3)
                Console.WriteLine(number2);
            else
                Console.WriteLine(number3);


            //Task 9


            Console.WriteLine("Enter your Grade");
            char Grade;
            char.TryParse(Console.ReadLine(), out Grade);
            
            switch (Grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("fair");
                    break;
                case 'E':
                    Console.WriteLine("failed");
                    break;
                default:
                    Console.WriteLine("char is not A B C D E");
                    break;
            }


            //Task 10


            int sum =0;

            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("total of numbers 1:100 is " + sum);



            //Task 11


            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i+" * 3 = "+(i*3));
            }



            //Task 12


            Console.WriteLine("Enter one char");
            char c;
            char.TryParse(Console.ReadLine(), out c);

            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                Console.WriteLine(c + " is an alphabet.");
            else
                Console.WriteLine(c + " is not an alphabet.");


            Console.Read();

        }
    }
}
