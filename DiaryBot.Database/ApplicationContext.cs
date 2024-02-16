using DiaryBot.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace DiaryBot.Database
{
    public class ApplicationContext : DbContext
    {

        private static ApplicationContext instance;
        public static ApplicationContext Instance
        {
            get => instance ?? (instance = new ApplicationContext());
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupSubject> GroupSubject { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<LessonMark> LessonMark { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=stud-mssql.sttec.yar.ru,38325;Database=user300_db;User Id=user300_db; Password=user300;TrustServerCertificate=True");
        }


    }
}
