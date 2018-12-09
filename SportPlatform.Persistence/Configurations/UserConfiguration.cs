using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class UserConfiguration
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(c => c.Specialist)
                .WithOne(c => c.User)
                .HasForeignKey<Specialist>(c => c.SpecialistId);
            builder.HasOne(c => c.Client)
                .WithOne(c => c.User)
                .HasForeignKey<Client>(c => c.ClientId);
                
        }
    }
}
