using Microsoft.EntityFrameworkCore;

namespace StudentInfoDemo.Models
{
    public class StudentInfoDbContext:DbContext
    {
        public StudentInfoDbContext(DbContextOptions option) : base(option)
        { 
        }
      public DbSet<Student> Students { get; set; }
    }
}
