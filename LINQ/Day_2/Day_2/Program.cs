using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company_SDEntities1 context = new Company_SDEntities1();
            
            #region Task 1
            
            Department department = new Department
            {
                Dname = "D10",
                Dnum = 50
                
            };

            //Employee employee = new Employee
            //{
            //    SSN = 999999,
            //    Fname = "Kerem",
            //    Lname = "Adel",
            //    Salary = 20000,
            //    //Department = department

            //};

            //context.Departments.Add(department);
            //context.SaveChanges();


            //Department De = context.Departments.Where(d => d.Dnum == 50).First();

            ////De.Dname = "update";
            ////context.SaveChanges();

            //context.Departments.Remove(De);
            //context.SaveChanges();

            #endregion

            #region Task 2

            //var DataDepartments = context.getDataDepartment();
            //foreach (var item in DataDepartments)
            //{
            //    Console.WriteLine(item.DepartmentName + "....." + item.countEmployee + "...." + item.sumSalary);
            //}


            #endregion

            #region Task 3

            //Employee Emp = context.Employees.First();
            //Emp.Salary -= 1000;

            //Company_SDEntities1 context2 = new Company_SDEntities1();

            //Employee Emp2 = context2.Employees.First();
            //Emp2.Salary -= 1000;

            //context.SaveChanges();

            //try
            //{
            //    context2.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException ex)
            //{
            //    var value = ex.Entries.First();
            //    value.Reload();

            //    Emp2.Salary -= 1000;
            //    context2.SaveChanges();

            //}
            #endregion

            #region Task 4

            Employee Emp = context.Employees.First();
            Emp.Salary -= 1000;

            Company_SDEntities1 context2 = new Company_SDEntities1();

            Employee Emp2 = context2.Employees.First();
            Emp2.Salary -= 1000;

            Company_SDEntities1 context3 = new Company_SDEntities1();

            Employee Emp3 = context2.Employees.First();
            Emp3.Salary -= 1000;

            Company_SDEntities1 context4 = new Company_SDEntities1();

            Employee Emp4 = context2.Employees.First();
            Emp4.Salary -= 1000;

            List<Employee> employees = new List<Employee> {Emp2,Emp3,Emp4};

            context.SaveChanges();
            do
            {
                try
                {
                    context2.SaveChanges();
                    context3.SaveChanges();
                    context4.SaveChanges(); 

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    var values = ex.Entries;

                    foreach (var item in values)
                    {
                        item.Reload();
                        for (int i = 0; i < employees.Count; i++)
                        {
                            employees[i].Salary -= 1000;

                        }


                    }

                    employees.RemoveAt(0);
                }
            } while (employees != null);

            #endregion
            Console.ReadLine();
        }
    }
}
