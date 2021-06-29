using Microsoft.EntityFrameworkCore;
using Session_18_Exercises.Entity_Framework.Configuration;
using Session_18_Exercises.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18_Exercises.Entity_Framework.Context {
    public class StudentContext : DbContext{

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected StudentContext() : base(){

        }

        public StudentContext(DbContextOptions options): base(options) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QGED0UI;Initial Catalog=Session18;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
