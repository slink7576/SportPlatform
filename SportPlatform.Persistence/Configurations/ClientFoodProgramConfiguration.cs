using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class ClientFoodProgramConfiguration
    {
        public void Configure(EntityTypeBuilder<ClientFoodProgram> builder)
        {
            builder.HasKey(c => new { c.ClientId, c.FoodProgramId });

            builder.HasOne(c => c.Client)
                .WithMany(c => c.ClientFoodPrograms)
                .HasForeignKey(c => c.ClientId);

            builder.HasOne(c => c.FoodProgram)
                .WithMany(c => c.ClientFoodPrograms)
                .HasForeignKey(c => c.FoodProgramId);
        }
    }
}
