namespace Lap_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region one employee read and write
            //Employee e1 = new Employee();
            //Console.WriteLine("enter id");
            //e1.SetId(int.Parse(Console.ReadLine()));
            //Console.WriteLine("enter name");
            //e1.SetName(Console.ReadLine());
            //Console.WriteLine("enter age");
            //e1.SetAge(int.Parse(Console.ReadLine()));
            //Console.WriteLine("enter salary");
            //e1.SetSalary(decimal.Parse(Console.ReadLine()));
            //Console.WriteLine("enter email");
            //e1.SetEmail(Console.ReadLine());
            //Console.WriteLine("enter password");
            //e1.SetPassword(Console.ReadLine());

            //Console.WriteLine("==========================================");
            //e1.PrintV1();
            //Console.WriteLine("==========================================");
            //Console.WriteLine(e1.PrintV2());
            #endregion

            #region one student read and write
            //Student s1 = new Student();
            //Console.WriteLine("enter id");
            //s1.SetId(int.Parse(Console.ReadLine()));
            //Console.WriteLine("enter name");
            //s1.SetName(Console.ReadLine());
            //Console.WriteLine("enter age");
            //s1.SetAge(int.Parse(Console.ReadLine()));
            //Console.WriteLine("enter address");
            //s1.SetAddress(Console.ReadLine());
            //Console.WriteLine("enter email");
            //s1.SetEmail(Console.ReadLine());
            //Console.WriteLine("enter password");
            //s1.SetPassword(Console.ReadLine());

            //Console.WriteLine("==========================================");
            //s1.PrintV1();
            //Console.WriteLine("==========================================");
            //Console.WriteLine(s1.PrintV2());
            #endregion

            #region array of 3 employees read at runtime and print
            //Employee[] employees = new Employee[3];
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    employees[i] = new Employee();

            //    Console.WriteLine($"Employee at index {i}");
            //    Console.WriteLine("enter id");
            //    employees[i].SetId(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("enter name");
            //    employees[i].SetName(Console.ReadLine());
            //    Console.WriteLine("enter age");
            //    employees[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("enter salary");
            //    employees[i].SetSalary(decimal.Parse(Console.ReadLine()));
            //    Console.WriteLine("enter email");
            //    employees[i].SetEmail(Console.ReadLine());
            //    Console.WriteLine("enter password");
            //    employees[i].SetPassword(Console.ReadLine());
            //}

            //Console.WriteLine("==========================================");
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    employees[i].PrintV1();
            //}
            //Console.WriteLine("==========================================");
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].PrintV2());
            //}
            #endregion

            #region array of 3 students read at runtime and print
            //Student[] students = new Student[3];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"Student at index {i}");
            //    Console.WriteLine("enter id");
            //    students[i].SetId(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("enter name");
            //    students[i].SetName(Console.ReadLine());
            //    Console.WriteLine("enter age");
            //    students[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("enter address");
            //    students[i].SetAddress(Console.ReadLine());
            //    Console.WriteLine("enter email");
            //    students[i].SetEmail(Console.ReadLine());
            //    Console.WriteLine("enter password");
            //    students[i].SetPassword(Console.ReadLine());
            //}

            //Console.WriteLine("==========================================");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    students[i].PrintV1();
            //}
            //Console.WriteLine("==========================================");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i].PrintV2());
            //}

            #endregion

            #region array of 10 employees and choose index

            //int index, tmp, id;
            //bool check = false;
            //char ch;
            //Employee[] employees = new Employee[10];

            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter index from 0 to 9");
            //        index = int.Parse(Console.ReadLine());
            //    } while (index < 0 || index > 9);
            //    employees[index] = new Employee();
            //    do
            //    {
            //        Console.WriteLine("Enter id");
            //        id = int.Parse(Console.ReadLine());
            //        check = false;
            //        for (int i = 0; i < employees.Length; i++)
            //        {
            //            if (employees[i] != null)
            //            {
            //                if (id == employees[i].GetId() && i != index)
            //                {
            //                    check = true;
            //                }
            //            }

            //        }
            //    } while (check || id <= 0);
            //    employees[index].SetId(id);

            //    Console.WriteLine("Enter name");
            //    employees[index].SetName(Console.ReadLine());
            //    do
            //    {
            //        Console.WriteLine("Enter age");
            //        tmp = int.Parse(Console.ReadLine());
            //    } while (tmp < 18 || tmp > 60);
            //    employees[index].SetAge(tmp);

            //    Console.WriteLine("Enter salary");
            //    employees[index].SetSalary(decimal.Parse(Console.ReadLine()));

            //    Console.WriteLine("Enter email");
            //    employees[index].SetEmail(Console.ReadLine());

            //    Console.WriteLine("Enter Password");
            //    employees[index].SetPassword(Console.ReadLine());

            //    Console.WriteLine("Continue y or n");
            //    ch = char.Parse(Console.ReadLine());

            //} while (ch == 'y');

            //Console.WriteLine("==========================================");
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    if (employees[i] != null)
            //    {
            //        employees[i].PrintV1();
            //    }
            //}
            //Console.WriteLine("==========================================");
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    if (employees[i] != null)
            //    {
            //        Console.WriteLine(employees[i].PrintV2());
            //    }
            //}
            #endregion

            #region array of 10 Students and choose index

            //int index, tmp, id;
            //bool check;
            //char ch;
            //Student[] students = new Student[10];

            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter index from 0 to 9");
            //        index = int.Parse(Console.ReadLine());
            //    } while (index < 0 || index > 9);


            //    do
            //    {
            //        Console.WriteLine("Enter id");
            //        id = int.Parse(Console.ReadLine());
            //        check = false;
            //        for (int i = 0; i < students.Length; i++)
            //        {
            //            if (id == students[i].GetId() && i != index )
            //            {
            //                check = true;
            //            }

            //        }
            //    } while (check || id <= 0);
            //    students[index].SetId(id);

            //    Console.WriteLine("Enter name");
            //    students[index].SetName(Console.ReadLine());
            //    do
            //    {
            //        Console.WriteLine("Enter age");
            //        tmp = int.Parse(Console.ReadLine());
            //    } while (tmp < 18 || tmp > 60);
            //    students[index].SetAge(tmp);

            //    Console.WriteLine("Enter Address");
            //    students[index].SetAddress(Console.ReadLine());

            //    Console.WriteLine("Enter email");
            //    students[index].SetEmail(Console.ReadLine());

            //    Console.WriteLine("Enter Password");
            //    students[index].SetPassword(Console.ReadLine());

            //    Console.WriteLine("Continue y or n");
            //    ch = char.Parse(Console.ReadLine());

            //} while (ch == 'y');

            //Console.WriteLine("==========================================");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    if (students[i].GetName() != null)
            //    {
            //        students[i].PrintV1();
            //    }
            //}
            //Console.WriteLine("==========================================");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    if (students[i].GetName() != null)
            //    {
            //        Console.WriteLine(students[i].PrintV2());
            //    }
            //}
            #endregion
        }
    }
}
