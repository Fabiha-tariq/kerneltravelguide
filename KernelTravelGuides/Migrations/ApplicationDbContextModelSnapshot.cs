﻿// <auto-generated />
using System;
using KernelTravelGuides.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KernelTravelGuides.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KernelTravelGuides.Models.City", b =>
                {
                    b.Property<int>("city_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("city_id"), 1L, 1);

                    b.Property<string>("city_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("city_status")
                        .HasColumnType("bit");

                    b.Property<int>("country_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.HasKey("city_id");

                    b.HasIndex("country_id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Country", b =>
                {
                    b.Property<int>("country_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("country_id"), 1L, 1);

                    b.Property<string>("country_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("country_id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Feedback", b =>
                {
                    b.Property<int>("feedback_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("feedback_id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("feedback_desc")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("feedback_user_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("feedback_id");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Hotel", b =>
                {
                    b.Property<int>("hotel_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("hotel_id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("hotel_average")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hotel_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hotel_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("hotel_rating")
                        .HasColumnType("int");

                    b.Property<bool>("hotel_status")
                        .HasColumnType("bit");

                    b.HasKey("hotel_id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Messages", b =>
                {
                    b.Property<int>("messages_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("messages_id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("messages_content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("messages_desc")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("messages_status")
                        .HasColumnType("bit");

                    b.Property<string>("messages_user_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("messages_id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Packages", b =>
                {
                    b.Property<int>("packages_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("packages_id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("packages_desc")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("packages_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("packages_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("packages_or_price")
                        .HasColumnType("int");

                    b.Property<bool>("packages_status")
                        .HasColumnType("bit");

                    b.Property<int>("resorts_id")
                        .HasColumnType("int");

                    b.Property<int>("t_spot_id")
                        .HasColumnType("int");

                    b.Property<int>("tra_category_id")
                        .HasColumnType("int");

                    b.Property<int>("transport_id")
                        .HasColumnType("int");

                    b.HasKey("packages_id");

                    b.HasIndex("resorts_id");

                    b.HasIndex("t_spot_id");

                    b.HasIndex("tra_category_id");

                    b.HasIndex("transport_id");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Resorts", b =>
                {
                    b.Property<int>("resorts_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("resorts_id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("resorts_img1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resorts_img2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resorts_img3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resorts_location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resorts_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("resorts_status")
                        .HasColumnType("bit");

                    b.HasKey("resorts_id");

                    b.ToTable("Resorts");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Restaurants", b =>
                {
                    b.Property<int>("restaurants_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("restaurants_id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("restaurants_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("restaurants_location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("restaurants_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("restaurants_status")
                        .HasColumnType("bit");

                    b.HasKey("restaurants_id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.TouriestSpots", b =>
                {
                    b.Property<int>("t_spot_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("t_spot_id"), 1L, 1);

                    b.Property<int>("country_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("t_spot_desc")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t_spot_img1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t_spot_img2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t_spot_img3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t_spot_locaion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t_spot_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("t_spot_rating")
                        .HasColumnType("int");

                    b.Property<bool>("t_spot_status")
                        .HasColumnType("bit");

                    b.HasKey("t_spot_id");

                    b.HasIndex("country_id");

                    b.ToTable("TouriestSpots");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Transport", b =>
                {
                    b.Property<int>("transport_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("transport_id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("transport_desc")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("transport_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("transport_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("transport_price")
                        .HasColumnType("int");

                    b.Property<int>("transport_rating")
                        .HasColumnType("int");

                    b.Property<bool>("transport_status")
                        .HasColumnType("bit");

                    b.HasKey("transport_id");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.TravelCategory", b =>
                {
                    b.Property<int>("tra_category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tra_category_id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("tra_category_desc")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tra_category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("tra_category_status")
                        .HasColumnType("bit");

                    b.HasKey("tra_category_id");

                    b.ToTable("TravelCategories");
                });

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
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

            modelBuilder.Entity("KernelTravelGuides.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.City", b =>
                {
                    b.HasOne("KernelTravelGuides.Models.Country", "country")
                        .WithMany()
                        .HasForeignKey("country_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.Packages", b =>
                {
                    b.HasOne("KernelTravelGuides.Models.Resorts", "resorts")
                        .WithMany()
                        .HasForeignKey("resorts_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KernelTravelGuides.Models.TouriestSpots", "t_spot")
                        .WithMany()
                        .HasForeignKey("t_spot_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KernelTravelGuides.Models.TravelCategory", "tra_category")
                        .WithMany()
                        .HasForeignKey("tra_category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KernelTravelGuides.Models.Transport", "transport")
                        .WithMany()
                        .HasForeignKey("transport_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("resorts");

                    b.Navigation("t_spot");

                    b.Navigation("tra_category");

                    b.Navigation("transport");
                });

            modelBuilder.Entity("KernelTravelGuides.Models.TouriestSpots", b =>
                {
                    b.HasOne("KernelTravelGuides.Models.Country", "country")
                        .WithMany()
                        .HasForeignKey("country_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
