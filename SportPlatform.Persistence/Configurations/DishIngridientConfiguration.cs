using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class DishIngridientConfiguration
    {
        public void Configure(EntityTypeBuilder<DishIngridient> builder)
        {
            builder.HasKey(c => new { c.DishId, c.IngridientId });

            builder.HasOne(c => c.Dish)
                .WithMany(c => c.DishIngridients)
                .HasForeignKey(c => c.DishId);

            builder.HasOne(c => c.Ingridient)
                .WithMany(c => c.DishIngridients)
                .HasForeignKey(c => c.IngridientId);
        }
    }
}
