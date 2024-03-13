using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1

            //int[,] arr1 = new int[2, 3];
            //int[,] arr2 = new int[2, 3];
            //int[,] result = new int[arr1.GetLength(0)+arr2.GetLength(0), arr1.GetLength(1)];

            //Console.WriteLine("Enter "+(arr1.GetLength(0) * arr1.GetLength(1)) + (arr2.GetLength(0) * arr2.GetLength(1)) + " Numbers");
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //        result[i, j] = arr1[i, j];
            //    }
            //}
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //        result[i + arr1.GetLength(0), j] = arr2[i, j];
            //    }
            //}
            //for (int i = 0; i < result.GetLength(0); i++)
            //{
            //    for (int j = 0; j < result.GetLength(1); j++)
            //    {
            //        Console.WriteLine(result[i, j]);
            //    }
            //}




            //int[,] arr1 = new int[3, 3];
            //int[,] arr2 = new int[2, 5];
            //int[,] result = new int[arr1.GetLength(0) + arr2.GetLength(0), arr1.GetLength(1)+ arr2.GetLength(1)];

            //Console.WriteLine("Enter "+(arr1.GetLength(0)* arr1.GetLength(1))+(arr2.GetLength(0)* arr2.GetLength(1))+" Numbers");
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //        result[i, j] = arr1[i, j];
            //    }
            //}
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //        result[i + arr1.GetLength(0), j] = arr2[i, j];
            //    }
            //}
            //for (int i = 0; i < result.GetLength(0); i++)
            //{
            //    for (int j = 0; j < result.GetLength(1); j++)
            //    {
            //        if(result[i, j] != 0)
            //        {
            //            Console.WriteLine(result[i, j]);
            //        }
            //    }
            //}
            #endregion

            #region Task 2

            //int[,] TwoDimArray = new int[2, 3];
            //int sum = 0;
            //Console.WriteLine("Enter " + (TwoDimArray.GetLength(0) * TwoDimArray.GetLength(1)) + " Numbers");
            //for (int i = 0; i < TwoDimArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TwoDimArray.GetLength(1); j++)
            //    {
            //        TwoDimArray[i, j] = int.Parse(Console.ReadLine());
            //        sum += TwoDimArray[i, j];
            //    }
            //}
            //Console.WriteLine("Sum is " + sum);
            //Console.WriteLine("Average is " + ((float)sum /(float) TwoDimArray.Length));
            #endregion

            #region Task 3


            //string str = Console.ReadLine();
            //int[] arrstr = new int[str.Length];
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            arrstr[i]++;
            //        }
            //    }
            //    Console.WriteLine(str[i] +" : "+ arrstr[i]);
            //}
            #endregion

            #region Task 4


            //string str = Console.ReadLine();
            //char[] arrstr = new char[str.Length];
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            //        arrstr[i] = str[i];

            //}

            //for (int i = 0; i < arrstr.Length; i++)
            //{
            //    if (arrstr[i]!='\0')
            //        Console.Write(arrstr[i]);
            //}
            #endregion

            #region Task 5


            //List<float> list = new List<float>();
            //for (int i = 0; i < 5; i++)
            //{
            //    list.Add(float.Parse(Console.ReadLine()));
            //}            
            //list.Sort();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion

            #region Task 6


            //Dictionary<int, string> student = new Dictionary<int, string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    student.Add(i+1, Console.ReadLine());
            //}
            //for (int i = 0; i < student.Count; i++)
            //{
            //    Console.WriteLine(student.ElementAt(i).Key + " : " + student.ElementAt(i).Value);
            //}
            #endregion


            #region Task 7


            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}
            // 0 1 2 3 4
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}
            // 0 1 2 3 4 6 7 8 9
            #endregion


            #region Task 8


            //Stack<string> myStack = new Stack<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    myStack.Push(Console.ReadLine());
            //}
            //foreach (string item in myStack)
            //{
            //    Console.WriteLine(item);
            //}



            //Queue<string> myQueue = new Queue<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    myQueue.Enqueue(Console.ReadLine());
            //}
            //foreach (string item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Task 9

            //int[][] JaggedArray = new int[5][];
            //JaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            //JaggedArray[1] = new int[] { 6, 7, 8 };
            //JaggedArray[2] = new int[] { 9, 10 };
            //JaggedArray[3] = new int[] { 11 };
            //JaggedArray[4] = new int[] { 12, 13, 14, 15, 16, 17 };

            //for (int i = 0; i < JaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < JaggedArray[i].Length; j++)
            //    {
            //        Console.WriteLine(JaggedArray[i][j]);
            //    }
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
