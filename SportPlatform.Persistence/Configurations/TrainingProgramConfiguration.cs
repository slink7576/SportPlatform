using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class TrainingProgramConfiguration
    {
        public void Configure(EntityTypeBuilder<TrainingProgram> builder)
        {
            builder.HasOne(c => c.Specialist).WithMany(c => c.TrainingPrograms);
            builder.HasMany(c => c.Trainings);
        }
    }
}
