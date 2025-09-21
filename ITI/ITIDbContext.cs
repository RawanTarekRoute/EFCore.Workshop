using ITI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITI
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=DESKTOP-QK0IFST\\MSSQLSERVERR;Database=ITI02;Trusted_Connection=True;TrustServerCertificate =True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }

    }
}
