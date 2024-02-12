using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Data : DbContext
    {
        public Data():base("name=School_DB") 
        { 

        }
        
        public DbSet<Department> Departments { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<TeacherTransfere> TeacherTransferes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().ToTable("Department");

            modelBuilder.Entity<School>().ToTable("School");

            modelBuilder.Entity<Teacher>().ToTable("Teacher");

            modelBuilder.Entity<TeacherTransfere>().ToTable("TeacherTransfere");

        }

    }
}
