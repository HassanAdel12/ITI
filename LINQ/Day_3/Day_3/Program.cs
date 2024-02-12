using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer<Data>(new DropCreateDatabaseIfModelChanges<Data>());
            Database.SetInitializer<Data>(new MigrateDatabaseToLatestVersion<Data, Migrations.Configuration>());

            Data context = new Data();

            //Department department = new Department() { Name = "Dept2" };
            //context.Departments.Add(department);

            //School school = new School()
            //{
            //    Name = "School 1",
            //    Type = "SType 1",
            //    DepartmentID = 1,
            //};

            //context.Schools.Add(school);

            //School school2 = new School()
            //{
            //    Name = "School 2",
            //    Type = "SType 2",
            //    DepartmentID = 1,
            //};

            //context.Schools.Add(school2);

            //Teacher teacher = new Teacher()
            //{
            //    Name = "Hassan",
            //    NationalID = "1234567891234567",
            //    BirthDate = DateTime.Now,
            //    Phone = "012100032641",
            //    Address = "Giza",
            //    HiringDate = DateTime.Now,
            //    QualificationDate = DateTime.Now,
            //    SchoolID = 3,
            //};

            //context.Teachers.Add(teacher);

            //Teacher teacher2 = new Teacher()
            //{
            //    Name = "Adel",
            //    NationalID = "1234567891234567",
            //    BirthDate = DateTime.Now,
            //    Phone = "012100032641",
            //    Address = "Giza",
            //    HiringDate = DateTime.Now,
            //    QualificationDate = DateTime.Now,
            //    SchoolID = 4,
            //};

            //context.Teachers.Add(teacher2);

            //TeacherTransfere teacherTransfere = new TeacherTransfere()
            //{
            //    TeacherID = 1,
            //    FromSchoolID = 2,
            //    ToSchoolID = 1,
            //    Date = DateTime.Now,
            //};

            //teacherTransfere.Transfere();

            //TeacherTransfere teacherTransfere2 = new TeacherTransfere()
            //{
            //    TeacherID = 2,
            //    FromSchoolID = 1,
            //    ToSchoolID = 2,
            //    Date = DateTime.Now,
            //};

            //teacherTransfere2.Transfere();

            context.SaveChanges();


        }
    }
}
