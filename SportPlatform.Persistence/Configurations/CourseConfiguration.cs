using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class CourseConfiguration
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(c => c.Worker).WithMany(c => c.Courses);
        }
    }
}
