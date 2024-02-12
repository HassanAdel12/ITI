using LINQtoObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //var Query1 = from b in SampleData.Books
            //             select new { b.Title, b.Isbn };

            //foreach (var item in Query1)
            //{
            //    Console.WriteLine($"Title : {item.Title} ,Isbn : {item.Isbn}");
            //}

            #endregion

            #region Task 2

            //IEnumerable<Book> Query2 = (from b in SampleData.Books
            //                            where b.Price > 25
            //                            select b).Take(3);

            //foreach (var item in Query2)
            //{
            //    Console.WriteLine($"Isbn : {item.Isbn} ,Title : {item.Title} ,Price : {item.Price}");
            //}

            #endregion

            #region Task 3

            //var Query3V1 = from b in SampleData.Books
            //               join p in SampleData.Publishers
            //               on b.Publisher equals p
            //               select new { b.Title, p.Name };

            //foreach (var item in Query3V1)
            //{
            //    Console.WriteLine($"Title : {item.Title} ,Publisher Name : {item.Name}");
            //}

            //Console.WriteLine("////////////////////////////////////////////////");

            //var Query3V2 = from b in SampleData.Books
            //               select new { b.Title, b.Publisher.Name };

            //foreach (var item in Query3V2)
            //{
            //    Console.WriteLine($"Title : {item.Title} ,Publisher Name : {item.Name}");
            //}

            #endregion

            #region Task 4

            //int Query4 = (from b in SampleData.Books
            //              where b.Price > 20
            //              select b).Count();

            //Console.WriteLine($"number of books which cost more than 20 : {Query4}");


            #endregion

            #region Task 5

            //var Query5 = from b in SampleData.Books
            //             orderby b.Subject.Name, b.Price descending
            //             select new { b.Title, b.Price, SubjectName = b.Subject.Name };

            //foreach (var item in Query5)
            //{
            //    Console.WriteLine($"Title : {item.Title} ,Price : {item.Price} ,Subject Name : {item.SubjectName}");
            //}

            #endregion

            #region Task 6

            //IEnumerable<string> Query6V1 = (from s in SampleData.Subjects
            //                                join b in SampleData.Books
            //                                on s equals b.Subject
            //                                select s.Name).Distinct();

            //foreach (var item in Query6V1)
            //{
            //    Console.WriteLine($"Subject Name : {item}");
            //}

            //Console.WriteLine("////////////////////////////////////////////////");

            //IEnumerable<string> Query6V2 = (from b in SampleData.Books
            //                                select b.Subject.Name).Distinct();

            //foreach (var item in Query6V2)
            //{
            //    Console.WriteLine($"Subject Name : {item}");
            //}

            #endregion

            #region Task 7

            //var Query7 = from b in SampleData.GetBooks().OfType<Book>()
            //             select new { b.Title, b.Price };

            //foreach (var item in Query7)
            //{
            //    Console.WriteLine($"Title : {item.Title} ,Price : {item.Price}");
            //}

            #endregion

            #region Task 8

            //var Query8V1 = from b in SampleData.Books
            //               group b by new
            //               {
            //                   b.Publisher,
            //                   b.Subject,
            //               } into newBooks
            //               select new
            //               {
            //                   Publisher = newBooks.Key.Publisher.Name,
            //                   Subject = newBooks.Key.Subject.Name,
            //                   Count = newBooks.Count(),
            //                   Names = string.Join(" , ", newBooks.Select(b => b.Title))
            //               };

            //foreach (var item in Query8V1)
            //{
            //    Console.WriteLine($"Publisher Name : {item.Publisher} ,Subject Name : {item.Subject} ,Count books:{item.Count} ,Names of Books : {item.Names}");
            //}


            //Console.WriteLine("///////////////////////////////////////////////////////////");


            //var Query8V2 = SampleData.Books.GroupBy(b => new { b.Publisher, b.Subject })
            //    .Select(g => new
            //    {
            //        Publisher = g.Key.Publisher.Name,
            //        Subject = g.Key.Subject.Name,
            //        Count = g.Count(),
            //        Names = string.Join(" , ", g.Select(b => b.Title))
            //    });

            //foreach (var item in Query8V2)
            //{
            //    Console.WriteLine($"Publisher Name : {item.Publisher} ,Subject Name : {item.Subject} ,Count books:{item.Count} ,Names of Books : {item.Names}");
            //}
            #endregion

            #region Task 9 Bouns

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter publisher name :");
                string publisherName = Console.ReadLine();

                Console.WriteLine("Enter sorting criteria :");
                string sortingCriteria = Console.ReadLine();

                Console.WriteLine("Enter sorting way :");
                string sortingWay = Console.ReadLine().ToUpper();

                IEnumerable<Book> Query9 = SampleData.FindBooksSorted(publisherName, sortingCriteria, sortingWay);

                foreach (var item in Query9)
                {
                    Console.WriteLine($"Title : {item.Title} ,Isbn : {item.Isbn} ,Price : {item.Price} ,Publisher Name : {item.Publisher.Name} ,Subject Name : {item.Subject.Name}");
                }
                Console.WriteLine();
            }

            #endregion
            Console.ReadLine();
        }
    }
}
