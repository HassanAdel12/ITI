using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Day_5Bouns.Models
{
    public partial class ContextDBSchool : DbContext
    {
        public ContextDBSchool()
            : base("name=ContextDBSchool")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.GPA)
                .HasPrecision(18, 0);
        }
    }
}
