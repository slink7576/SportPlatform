using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence.Configurations
{
    public class DishMenuConfiguration
    {
        public void Configure(EntityTypeBuilder<DishMenu> builder)
        {
            builder.HasKey(c => new { c.DishId, c.MenuId });

            builder.HasOne(c => c.Dish)
                .WithMany(c => c.DishMenus)
                .HasForeignKey(c => c.DishId);

            builder.HasOne(c => c.Menu)
                .WithMany(c => c.DishMenus)
                .HasForeignKey(c => c.MenuId);
        }
    }
}
