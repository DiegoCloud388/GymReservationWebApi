﻿// <auto-generated />
using System;
using GymReservationWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymReservationWebApi.Migrations
{
    [DbContext(typeof(ReservationDbContext))]
    [Migration("20231215095016_createReservationTime")]
    partial class createReservationTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GymReservationWebApi.Entities.CtlgReservationService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityState")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReservationServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2841),
                            EntityState = 1,
                            Name = "Volejbal"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2844),
                            EntityState = 1,
                            Name = "Stolní tenis"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2845),
                            EntityState = 1,
                            Name = "Nohejbal"
                        });
                });

            modelBuilder.Entity("GymReservationWebApi.Entities.CtlgReservationState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityState")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReservationStates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2706),
                            EntityState = 1,
                            Name = "Reservováno"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2742),
                            EntityState = 1,
                            Name = "Zrušeno"
                        });
                });

            modelBuilder.Entity("GymReservationWebApi.Entities.CtlgReservationTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("EntityState")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("ReservationTime");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2857),
                            EndTime = new TimeSpan(0, 8, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2860),
                            EndTime = new TimeSpan(0, 9, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2862),
                            EndTime = new TimeSpan(0, 10, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2864),
                            EndTime = new TimeSpan(0, 11, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2865),
                            EndTime = new TimeSpan(0, 12, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 12, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2867),
                            EndTime = new TimeSpan(0, 13, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 13, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2868),
                            EndTime = new TimeSpan(0, 14, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2870),
                            EndTime = new TimeSpan(0, 15, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2871),
                            EndTime = new TimeSpan(0, 16, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2872),
                            EndTime = new TimeSpan(0, 17, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 17, 0, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2874),
                            EndTime = new TimeSpan(0, 18, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 18, 0, 0, 0)
                        },
                        new
                        {
                            Id = 12,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2876),
                            EndTime = new TimeSpan(0, 19, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 19, 0, 0, 0)
                        },
                        new
                        {
                            Id = 13,
                            CreatedBy = "system",
                            CreatedDate = new DateTime(2023, 12, 15, 10, 50, 16, 54, DateTimeKind.Local).AddTicks(2877),
                            EndTime = new TimeSpan(0, 20, 30, 0, 0),
                            EntityState = 1,
                            StartTime = new TimeSpan(0, 20, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("GymReservationWebApi.Entities.GymReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityState")
                        .HasColumnType("int");

                    b.Property<int>("ReservationServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationStateId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationTimeId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationServiceId");

                    b.HasIndex("ReservationStateId");

                    b.HasIndex("ReservationTimeId");

                    b.HasIndex("UserId");

                    b.ToTable("GymReservations");
                });

            modelBuilder.Entity("GymReservationWebApi.Entities.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("AutomaticLogonEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifierUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GymReservationWebApi.Entities.GymReservation", b =>
                {
                    b.HasOne("GymReservationWebApi.Entities.CtlgReservationService", "ReservationService")
                        .WithMany()
                        .HasForeignKey("ReservationServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymReservationWebApi.Entities.CtlgReservationState", "ReservationState")
                        .WithMany()
                        .HasForeignKey("ReservationStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymReservationWebApi.Entities.CtlgReservationTime", "ReservationTime")
                        .WithMany()
                        .HasForeignKey("ReservationTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymReservationWebApi.Entities.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ReservationService");

                    b.Navigation("ReservationState");

                    b.Navigation("ReservationTime");

                    b.Navigation("User");
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
                    b.HasOne("GymReservationWebApi.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GymReservationWebApi.Entities.Identity.User", null)
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

                    b.HasOne("GymReservationWebApi.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GymReservationWebApi.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
