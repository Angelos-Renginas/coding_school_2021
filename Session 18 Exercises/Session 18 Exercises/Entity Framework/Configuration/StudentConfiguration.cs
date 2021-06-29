using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_18_Exercises.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18_Exercises.Entity_Framework.Configuration {
    public class StudentConfiguration : IEntityTypeConfiguration<Student> {
        public void Configure(EntityTypeBuilder<Student> builder) {

            builder.ToTable("Students", "Session18");

            builder.Property(x => x.ID).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).HasMaxLength(150).IsRequired(true);

            builder.Property(x => x.Surname).HasMaxLength(200).IsRequired(true);

            builder.Property(x => x.BirthDate).IsRequired(true);

            builder.Property(x => x.Address);
        }
    }
}
