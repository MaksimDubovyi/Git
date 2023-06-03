using Microsoft.EntityFrameworkCore;

namespace Git.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentContext(DbContextOptions<StudentContext> options)
           : base(options)
        {
            if (Database.EnsureCreated())
            {
                Students.Add(new Student { Name = "Иван", Surname = "Иванов", Age = 20, GPA = 10.5f });
                Students.Add(new Student { Name = "Сергей", Surname = "Сергеев", Age = 23, GPA = 11.5f });
                Students.Add(new Student { Name = "Петр", Surname = "Петров", Age = 25, GPA = 12f });
                SaveChanges();
            }
        }
    }
}
