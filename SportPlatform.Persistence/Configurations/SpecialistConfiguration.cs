using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class SpecialistConfiguration
    {
        public void Configure(EntityTypeBuilder<Specialist> builder)
        {
            builder.HasOne(c => c.User);
            builder.HasMany(c => c.TrainingPrograms);
            builder.HasMany(c => c.Certificates);
            builder.HasMany(c => c.WorkHistories);
            builder.HasMany(c => c.Certificates);
            builder.HasMany(c => c.FoodPrograms);
        }
    }
}
