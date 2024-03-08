using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Day_2API.Model
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext()
        {

        }

        public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<City> Citys { get; set; }
    }
}
