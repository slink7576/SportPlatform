using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class CertificateConfiguration
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.HasOne(c => c.Worker).WithMany(c => c.Certificates);
        }
    }
}
