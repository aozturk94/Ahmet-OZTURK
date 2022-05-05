using Microsoft.EntityFrameworkCore;
using StudentLessonApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Models.Concrete
{
    public class StudentLessonAppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=StudentLessonDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentLesson>().HasKey(sl => new { sl.StudentId, sl.LessonId });
        }

    }
}
