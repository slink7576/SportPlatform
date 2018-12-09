using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class AdvanceConfiguration
    {
        public void Configure(EntityTypeBuilder<Advance> builder)
        {
            builder.HasOne(c => c.Specialist).WithMany(c => c.Advances);
        }
    }
}
