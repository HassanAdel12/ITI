using Microsoft.EntityFrameworkCore;

namespace Day_1.Model
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext()
        {

        }

        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

    }
}
