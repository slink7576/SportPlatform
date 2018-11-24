using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class TrainingActionConfiguration
    {
        public void Configure(EntityTypeBuilder<TrainingAction> builder)
        {
            builder.HasOne(c => c.Training).WithMany(c => c.TrainingActions);
        }
    }
}
