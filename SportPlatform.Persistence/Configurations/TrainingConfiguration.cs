using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class TrainingConfiguration
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.HasOne(c => c.TrainingProgram).WithMany(c => c.Trainings);
            builder.HasMany(c => c.TrainingActions);
        }
    }
}
