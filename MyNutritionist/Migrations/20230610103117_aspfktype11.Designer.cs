﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyNutritionist.Data;

#nullable disable

namespace MyNutritionist.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230610103117_aspfktype11")]
    partial class aspfktype11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NutriPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutriUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.Card", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CId"), 1L, 1);

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Card", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.DietPlan", b =>
                {
                    b.Property<int>("DPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DPID"), 1L, 1);

                    b.Property<string>("NutritionistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TotalCalories")
                        .HasColumnType("int");

                    b.HasKey("DPID");

                    b.HasIndex("NutritionistId");

                    b.ToTable("DietPlan", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.Ingredient", b =>
                {
                    b.Property<int>("IId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IId"), 1L, 1);

                    b.Property<double>("Calcium")
                        .HasColumnType("float");

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<double>("Carbs")
                        .HasColumnType("float");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Iron")
                        .HasColumnType("float");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<double>("SaturatedFat")
                        .HasColumnType("float");

                    b.Property<double>("Sodium")
                        .HasColumnType("float");

                    b.Property<double>("Sugar")
                        .HasColumnType("float");

                    b.Property<double>("VitaminA")
                        .HasColumnType("float");

                    b.Property<double>("VitaminC")
                        .HasColumnType("float");

                    b.HasKey("IId");

                    b.ToTable("Ingredient", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.Leaderboard", b =>
                {
                    b.Property<int>("LID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LID"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LID");

                    b.ToTable("Leaderboard", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.Progress", b =>
                {
                    b.Property<int>("PRId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PRId"), 1L, 1);

                    b.Property<int>("BurnedCalories")
                        .HasColumnType("int");

                    b.Property<int>("ConsumedCalories")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PremiumUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RegisteredUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PRId");

                    b.HasIndex("PremiumUserId");

                    b.HasIndex("RegisteredUserId");

                    b.ToTable("Progress", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.Recipe", b =>
                {
                    b.Property<int>("RID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RID"), 1L, 1);

                    b.Property<int?>("DietPlanDPID")
                        .HasColumnType("int");

                    b.Property<string>("NutritionistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RecipeLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCalories")
                        .HasColumnType("int");

                    b.HasKey("RID");

                    b.HasIndex("DietPlanDPID");

                    b.HasIndex("NutritionistId");

                    b.ToTable("Recipe", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.Admin", b =>
                {
                    b.HasBaseType("MyNutritionist.Models.ApplicationUser");

                    b.Property<string>("AspUserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.Nutritionist", b =>
                {
                    b.HasBaseType("MyNutritionist.Models.ApplicationUser");

                    b.Property<string>("AspUserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Nutritionist", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.PremiumUser", b =>
                {
                    b.HasBaseType("MyNutritionist.Models.ApplicationUser");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AspUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int?>("LeaderboardLID")
                        .HasColumnType("int");

                    b.Property<string>("NutritionistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasIndex("LeaderboardLID");

                    b.HasIndex("NutritionistId");

                    b.ToTable("PremiumUser", (string)null);
                });

            modelBuilder.Entity("MyNutritionist.Models.RegisteredUser", b =>
                {
                    b.HasBaseType("MyNutritionist.Models.ApplicationUser");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AspUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.ToTable("RegisteredUser", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyNutritionist.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyNutritionist.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyNutritionist.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyNutritionist.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyNutritionist.Models.Card", b =>
                {
                    b.HasOne("MyNutritionist.Models.PremiumUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MyNutritionist.Models.DietPlan", b =>
                {
                    b.HasOne("MyNutritionist.Models.Nutritionist", "Nutritionist")
                        .WithMany()
                        .HasForeignKey("NutritionistId");

                    b.Navigation("Nutritionist");
                });

            modelBuilder.Entity("MyNutritionist.Models.Progress", b =>
                {
                    b.HasOne("MyNutritionist.Models.PremiumUser", "PremiumUser")
                        .WithMany()
                        .HasForeignKey("PremiumUserId");

                    b.HasOne("MyNutritionist.Models.RegisteredUser", "RegisteredUser")
                        .WithMany()
                        .HasForeignKey("RegisteredUserId");

                    b.Navigation("PremiumUser");

                    b.Navigation("RegisteredUser");
                });

            modelBuilder.Entity("MyNutritionist.Models.Recipe", b =>
                {
                    b.HasOne("MyNutritionist.Models.DietPlan", null)
                        .WithMany("Recipes")
                        .HasForeignKey("DietPlanDPID");

                    b.HasOne("MyNutritionist.Models.Nutritionist", "Nutritionist")
                        .WithMany()
                        .HasForeignKey("NutritionistId");

                    b.Navigation("Nutritionist");
                });

            modelBuilder.Entity("MyNutritionist.Models.Admin", b =>
                {
                    b.HasOne("MyNutritionist.Models.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("MyNutritionist.Models.Admin", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyNutritionist.Models.Nutritionist", b =>
                {
                    b.HasOne("MyNutritionist.Models.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("MyNutritionist.Models.Nutritionist", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyNutritionist.Models.PremiumUser", b =>
                {
                    b.HasOne("MyNutritionist.Models.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("MyNutritionist.Models.PremiumUser", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("MyNutritionist.Models.Leaderboard", null)
                        .WithMany("Users")
                        .HasForeignKey("LeaderboardLID");

                    b.HasOne("MyNutritionist.Models.Nutritionist", null)
                        .WithMany("PremiumUsers")
                        .HasForeignKey("NutritionistId");
                });

            modelBuilder.Entity("MyNutritionist.Models.RegisteredUser", b =>
                {
                    b.HasOne("MyNutritionist.Models.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("MyNutritionist.Models.RegisteredUser", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyNutritionist.Models.DietPlan", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("MyNutritionist.Models.Leaderboard", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("MyNutritionist.Models.Nutritionist", b =>
                {
                    b.Navigation("PremiumUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
