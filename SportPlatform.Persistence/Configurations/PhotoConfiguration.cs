using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class PhotoConfiguration
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasOne(c => c.User).WithMany(c => c.Photos);
        }
    }
}
