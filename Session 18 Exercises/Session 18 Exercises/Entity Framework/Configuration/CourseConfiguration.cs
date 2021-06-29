using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_18_Exercises.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18_Exercises.Entity_Framework.Configuration {
    class CourseConfiguration : IEntityTypeConfiguration<Course> {
        public void Configure(EntityTypeBuilder<Course> builder) {
            builder.ToTable("Course", "Session18");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).ValueGeneratedOnAdd();

            builder.Property(x => x.Category).HasMaxLength(150).IsRequired(true);

            builder.Property(x => x.Date).IsRequired(true);

            builder.Property(x => x.Duration).IsRequired(true);
        }
    }
}
