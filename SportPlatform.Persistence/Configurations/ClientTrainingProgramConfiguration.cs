using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class ClientTrainingProgramConfiguration
    {
        public void Configure(EntityTypeBuilder<ClientTrainingProgram> builder)
        {
            builder.HasKey(c => new { c.ClientId, c.TrainingProgramId });

            builder.HasOne(c => c.Client)
                .WithMany(c => c.ClientTrainingPrograms)
                .HasForeignKey(c => c.ClientId);

            builder.HasOne(c => c.TrainingProgram)
                .WithMany(c => c.ClientTrainingPrograms)
                .HasForeignKey(c => c.TrainingProgramId);
        }
    }
}
