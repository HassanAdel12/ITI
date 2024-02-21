namespace frist_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //int[] arr = new int[10];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter index {i} of array.");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("===========================================");
            //Console.WriteLine($"the max value of array is {arr.Max()}");
            //Console.WriteLine($"the min value of array is {arr.Min()}");
            #endregion

            #region Task 2
            //int[] arr2 = new int[10];
            //int temp = 0;

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine($"Enter index {i} of array.");
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = i+1; j < arr2.Length; j++)
            //    {
            //        if (arr2[i] < arr2[j])
            //        {
            //            temp = arr2[i];
            //            arr2[i] = arr2[j];
            //            arr2[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Array sort ");
            //Console.WriteLine("===============================================");
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task 3
            //int[] arr3 = new int[10];
            //int search ,index;
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine($"Enter index {i} of array.");
            //    arr3[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("====================================");
            //Console.WriteLine("enter number to search");
            //search = int.Parse(Console.ReadLine());
            //Console.WriteLine("====================================");
            //index = Array.FindIndex(arr3, element => element == search);
            //if (index == -1)
            //{
            //    Console.WriteLine($"not found");
            //}
            //else 
            //{
            //    Console.WriteLine($"found at index {index}");
            //}
            #endregion

            #region Task 4
            //int[,] TwoDimArray = new int[3, 4];
            //int sum = 0;
            //Console.WriteLine($"Enter {(TwoDimArray.GetLength(0) * TwoDimArray.GetLength(1))} indexs");
            //for (int i = 0; i < TwoDimArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TwoDimArray.GetLength(1); j++)
            //    {
            //        TwoDimArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("=====================================");
            //Console.WriteLine("Print Two Dim Array");
            //Console.WriteLine("=====================================");
            //for (int i = 0; i < TwoDimArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TwoDimArray.GetLength(1); j++)
            //    {
            //        Console.Write($"{TwoDimArray[i, j]} , ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=====================================");
            //Console.WriteLine($"Number of rows : {TwoDimArray.GetLength(0)}");
            //Console.WriteLine("=====================================");
            //Console.WriteLine($"Number of columns : {TwoDimArray.GetLength(1)}");
            //Console.WriteLine("=====================================");
            #endregion

            #region Task 5
            int year, month, day, leapYear = 2020;
            int[] daysOfMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            ///1,3,5,7,8,10,12     31days
            ///4,6,9,11           30 days
            ///2      28,29 leap year    2000,2004,2008,2020

            /// get year
            do
            {
                Console.WriteLine("plz enter your year from 1950->2023");
                year = int.Parse(Console.ReadLine());
            } while (year < 1950 || year > 2023);

            ///check leap year
            while (year <= leapYear)
            {
                if (year == leapYear)
                {
                    daysOfMonth[1] = 29;
                }
                leapYear -= 4;
            }
            ///get month
            do
            {
                Console.WriteLine("plz enter your month");
                month = int.Parse(Console.ReadLine());
            } while (month < 1 || month > 12);
            ///get day and check for array 
            do
            {
                Console.WriteLine("plz enter your day");
                day = int.Parse(Console.ReadLine());
            } while (day < 1 || day > daysOfMonth[month - 1]);

            int currentday = DateTime.Now.Day;
            int currentmonth = DateTime.Now.Month;
            int currentyear = DateTime.Now.Year;
            int differenceday, differencemonth, differenceyear;

            do
            {
                differenceday = currentday - day;
                differencemonth = currentmonth - month;
                differenceyear = currentyear - year;
                if (differencemonth < 0)
                {
                    currentyear--;
                    currentmonth += 12;
                }
                else if (differenceday < 0)
                {
                    currentmonth--;
                    currentday += daysOfMonth[month - 1];
                }


            } while (differenceday < 0 || differencemonth < 0 || differenceyear < 0);
            Console.WriteLine($"========================================================");
            Console.WriteLine($"age for day : {differenceday}");
            Console.WriteLine($"age for month : {differencemonth}");
            Console.WriteLine($"age for year : {differenceyear}");
            #endregion
        }
    }
}
