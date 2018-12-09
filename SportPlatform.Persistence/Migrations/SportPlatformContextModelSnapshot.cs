﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportPlatform.Persistence;

namespace SportPlatform.Persistence.Migrations
{
    [DbContext(typeof(SportPlatformContext))]
    partial class SportPlatformContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportPlatform.Domain.Entities.Advance", b =>
                {
                    b.Property<int>("AdvanceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("SpecialistId");

                    b.Property<string>("Title");

                    b.HasKey("AdvanceId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Advances");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Certificate", b =>
                {
                    b.Property<int>("CertificateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AchieveDate");

                    b.Property<string>("CertificateUrl");

                    b.Property<string>("Name");

                    b.Property<int>("SpecialistId");

                    b.HasKey("CertificateId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Height");

                    b.Property<int>("UserId");

                    b.Property<double>("Weight");

                    b.HasKey("ClientId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.ClientFoodProgram", b =>
                {
                    b.Property<int>("ClientFoodProgramId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("FoodProgramId");

                    b.HasKey("ClientFoodProgramId");

                    b.HasIndex("ClientId");

                    b.HasIndex("FoodProgramId");

                    b.ToTable("ClientFoodPrograms");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.ClientTrainingProgram", b =>
                {
                    b.Property<int>("ClientTrainingProgramId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("TrainingProgramId");

                    b.HasKey("ClientTrainingProgramId");

                    b.HasIndex("ClientId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("ClientTrainingPrograms");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DocumentUrl");

                    b.Property<DateTime>("EndLearning");

                    b.Property<string>("Name");

                    b.Property<string>("Place");

                    b.Property<int>("SpecialistId");

                    b.Property<DateTime>("StartLearning");

                    b.HasKey("CourseId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calories");

                    b.Property<string>("Name");

                    b.Property<int>("Weight");

                    b.HasKey("DishId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.DishIngridient", b =>
                {
                    b.Property<int>("DishIngridientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DishId");

                    b.Property<int>("IngridientId");

                    b.HasKey("DishIngridientId");

                    b.HasIndex("DishId");

                    b.HasIndex("IngridientId");

                    b.ToTable("DishIngridients");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.DishMenu", b =>
                {
                    b.Property<int>("DishMenuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DishId");

                    b.Property<int>("MenuId");

                    b.HasKey("DishMenuId");

                    b.HasIndex("DishId");

                    b.HasIndex("MenuId");

                    b.ToTable("DishMenus");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.FoodProgram", b =>
                {
                    b.Property<int>("FoodProgramId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("SpecialistId");

                    b.HasKey("FoodProgramId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("FoodPrograms");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Ingridient", b =>
                {
                    b.Property<int>("IngridientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("IngridientId");

                    b.ToTable("Ingridients");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("FoodProgramId");

                    b.Property<DateTime>("Time");

                    b.HasKey("MenuId");

                    b.HasIndex("FoodProgramId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("PhotoUrl");

                    b.Property<DateTime>("PostDate");

                    b.Property<int>("UserId");

                    b.HasKey("PhotoId");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Specialist", b =>
                {
                    b.Property<int>("SpecialistId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About");

                    b.Property<int>("UserId");

                    b.Property<string>("WorkDescription");

                    b.Property<string>("WorkPlace");

                    b.Property<string>("WorkTitle");

                    b.HasKey("SpecialistId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DayOfWeek");

                    b.Property<string>("Description");

                    b.Property<int>("TrainingProgramId");

                    b.HasKey("TrainingId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.TrainingAction", b =>
                {
                    b.Property<int>("TrainingActionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Repeats");

                    b.Property<int>("TrainingId");

                    b.HasKey("TrainingActionId");

                    b.HasIndex("TrainingId");

                    b.ToTable("TrainingActions");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.TrainingProgram", b =>
                {
                    b.Property<int>("TrainingProgramId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("SpecialistId");

                    b.HasKey("TrainingProgramId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("PhotoUrl");

                    b.Property<bool>("SubmittedEmail");

                    b.Property<string>("Surname");

                    b.Property<int>("UserType");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.WorkHistory", b =>
                {
                    b.Property<int>("WorkHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndWork");

                    b.Property<int>("SpecialistId");

                    b.Property<DateTime>("StartWork");

                    b.Property<string>("Title");

                    b.HasKey("WorkHistoryId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("WorkHistories");
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Advance", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Specialist", "Specialist")
                        .WithMany("Advances")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Certificate", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Specialist", "Specialist")
                        .WithMany("Certificates")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Client", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.User", "User")
                        .WithOne("Client")
                        .HasForeignKey("SportPlatform.Domain.Entities.Client", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.ClientFoodProgram", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Client", "Client")
                        .WithMany("ClientFoodPrograms")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportPlatform.Domain.Entities.FoodProgram", "FoodProgram")
                        .WithMany("ClientFoodPrograms")
                        .HasForeignKey("FoodProgramId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.ClientTrainingProgram", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Client", "Client")
                        .WithMany("ClientTrainingPrograms")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportPlatform.Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("ClientTrainingPrograms")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Course", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Specialist", "Specialist")
                        .WithMany("Courses")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.DishIngridient", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Dish", "Dish")
                        .WithMany("DishIngridients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportPlatform.Domain.Entities.Ingridient", "Ingridient")
                        .WithMany("DishIngridients")
                        .HasForeignKey("IngridientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.DishMenu", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Dish", "Dish")
                        .WithMany("DishMenus")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportPlatform.Domain.Entities.Menu", "Menu")
                        .WithMany("DishMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.FoodProgram", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Specialist", "Specialist")
                        .WithMany("FoodPrograms")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Menu", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.FoodProgram", "FoodProgram")
                        .WithMany("Menus")
                        .HasForeignKey("FoodProgramId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Photo", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Specialist", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.User", "User")
                        .WithOne("Specialist")
                        .HasForeignKey("SportPlatform.Domain.Entities.Specialist", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.Training", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("Trainings")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.TrainingAction", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Training", "Training")
                        .WithMany("TrainingActions")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.TrainingProgram", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Specialist", "Specialist")
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportPlatform.Domain.Entities.WorkHistory", b =>
                {
                    b.HasOne("SportPlatform.Domain.Entities.Specialist", "Specialist")
                        .WithMany("WorkHistories")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
