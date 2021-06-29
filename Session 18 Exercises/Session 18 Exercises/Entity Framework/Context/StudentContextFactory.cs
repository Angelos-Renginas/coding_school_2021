using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18_Exercises.Entity_Framework.Context {
    public class StudentContextFactory : IDesignTimeDbContextFactory<StudentContext> {
        public StudentContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QGED0UI;Initial Catalog=Session18;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new StudentContext(optionsBuilder.Options);
        }
    }
}
