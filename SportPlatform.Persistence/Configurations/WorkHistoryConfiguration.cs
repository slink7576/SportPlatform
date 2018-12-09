using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class WorkHistoryConfiguration
    {
        public void Configure(EntityTypeBuilder<WorkHistory> builder)
        {
            builder.HasOne(c => c.Specialist)
                .WithMany(c => c.WorkHistories);
        }
    }
}
