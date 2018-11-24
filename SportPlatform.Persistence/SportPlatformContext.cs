using Microsoft.EntityFrameworkCore;
using SportPlatform.Domain.Entities;
using SportPlatform.Persistence.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Persistence
{
    public class SportPlatformContext : DbContext
    {
        public SportPlatformContext(DbContextOptions<SportPlatformContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        //public DbSet<DishIngridient> DishIngridients { get; set; }
        //public DbSet<DishMenu> DishMenus { get; set; }
        public DbSet<FoodProgram> FoodPrograms { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingAction> TrainingActions { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkHistory> WorkHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();
        }

    }
}
