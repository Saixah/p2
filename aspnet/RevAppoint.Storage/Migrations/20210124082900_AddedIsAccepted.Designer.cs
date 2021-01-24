﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RevAppoint.Storage;

namespace RevAppoint.Storage.Migrations
{
    [DbContext(typeof(RevAppointContext))]
    [Migration("20210124082900_AddedIsAccepted")]
    partial class AddedIsAccepted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("RevAppoint.Domain.POCOs.Appointment", b =>
                {
                    b.Property<long>("EntityID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ClientEntityID")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFufilled")
                        .HasColumnType("bit");

                    b.Property<long?>("ProfessionalEntityID")
                        .HasColumnType("bigint");

                    b.Property<long?>("TimeEntityID")
                        .HasColumnType("bigint");

                    b.HasKey("EntityID");

                    b.HasIndex("ClientEntityID");

                    b.HasIndex("ProfessionalEntityID");

                    b.HasIndex("TimeEntityID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.Time", b =>
                {
                    b.Property<long>("EntityID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("EntityID");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.User", b =>
                {
                    b.Property<long>("EntityID")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.Customer", b =>
                {
                    b.HasBaseType("RevAppoint.Domain.POCOs.User");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            EntityID = 637470557392729784L,
                            FirstName = "Melvin",
                            LastName = "Mac",
                            Password = "Password",
                            Username = "Username1"
                        },
                        new
                        {
                            EntityID = 637470557392765176L,
                            FirstName = "Barbara",
                            LastName = "Gross",
                            Password = "Password",
                            Username = "trombone"
                        },
                        new
                        {
                            EntityID = 637470557392765257L,
                            FirstName = "Faiza",
                            LastName = "Bowman",
                            Password = "Password",
                            Username = "chicken"
                        },
                        new
                        {
                            EntityID = 637470557392765264L,
                            FirstName = "Nathalie",
                            LastName = "Fellows",
                            Password = "Password",
                            Username = "foxtrail"
                        },
                        new
                        {
                            EntityID = 637470557392765268L,
                            FirstName = "Barney",
                            LastName = "Simons",
                            Password = "Password",
                            Username = "perseus"
                        },
                        new
                        {
                            EntityID = 637470557392765284L,
                            FirstName = "Adrianna",
                            LastName = "Prentice",
                            Password = "Password",
                            Username = "applepie"
                        },
                        new
                        {
                            EntityID = 637470557392765289L,
                            FirstName = "Maxim",
                            LastName = "Fowler",
                            Password = "Password",
                            Username = "candyfog"
                        });
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.Professional", b =>
                {
                    b.HasBaseType("RevAppoint.Domain.POCOs.User");

                    b.Property<int>("AppointmentLengthInHours")
                        .HasColumnType("int");

                    b.Property<long?>("AvailableTimeEntityID")
                        .HasColumnType("bigint");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AvailableTimeEntityID");

                    b.ToTable("Professional");

                    b.HasData(
                        new
                        {
                            EntityID = 637470557392789599L,
                            FirstName = "Shelley",
                            LastName = "Stacey",
                            Password = "BadPassword",
                            Username = "banjojudo",
                            AppointmentLengthInHours = 1,
                            Location = "Chicago",
                            Title = "Blacksmith"
                        },
                        new
                        {
                            EntityID = 637470557392792364L,
                            FirstName = "Salgado",
                            LastName = "Arnie",
                            Password = "BadPassword",
                            Username = "hotdogpeas",
                            AppointmentLengthInHours = 2,
                            Location = "Las Vegas",
                            Title = "Web Developer"
                        },
                        new
                        {
                            EntityID = 637470557392792407L,
                            FirstName = "Chanel",
                            LastName = "Tamera",
                            Password = "BadPassword",
                            Username = "psychobatman",
                            AppointmentLengthInHours = 3,
                            Location = "Las Vegas",
                            Title = "Driver"
                        },
                        new
                        {
                            EntityID = 637470557392792414L,
                            FirstName = "Lawrence",
                            LastName = "Gregg",
                            Password = "BadPassword",
                            Username = "brownbread",
                            AppointmentLengthInHours = 1,
                            Location = "New York",
                            Title = "Nurse"
                        },
                        new
                        {
                            EntityID = 637470557392792419L,
                            FirstName = "Ibrahim",
                            LastName = "Elis",
                            Password = "BadPassword",
                            Username = "oystersnatch",
                            AppointmentLengthInHours = 2,
                            Location = "New York",
                            Title = "Barber"
                        },
                        new
                        {
                            EntityID = 637470557392792442L,
                            FirstName = "Page",
                            LastName = "Branch",
                            Password = "BadPassword",
                            Username = "islandhorse",
                            AppointmentLengthInHours = 4,
                            Location = "Chicago",
                            Title = "Barber"
                        },
                        new
                        {
                            EntityID = 637470557392792450L,
                            FirstName = "Chante",
                            LastName = "Jacob",
                            Password = "BadPassword",
                            Username = "cocktailwave",
                            AppointmentLengthInHours = 12,
                            Location = "Chicago",
                            Title = "Web Developer"
                        });
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.Appointment", b =>
                {
                    b.HasOne("RevAppoint.Domain.POCOs.User", "Client")
                        .WithMany("Appointments")
                        .HasForeignKey("ClientEntityID");

                    b.HasOne("RevAppoint.Domain.POCOs.Professional", "Professional")
                        .WithMany()
                        .HasForeignKey("ProfessionalEntityID");

                    b.HasOne("RevAppoint.Domain.POCOs.Time", "Time")
                        .WithMany()
                        .HasForeignKey("TimeEntityID");

                    b.Navigation("Client");

                    b.Navigation("Professional");

                    b.Navigation("Time");
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.Customer", b =>
                {
                    b.HasOne("RevAppoint.Domain.POCOs.User", null)
                        .WithOne()
                        .HasForeignKey("RevAppoint.Domain.POCOs.Customer", "EntityID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.Professional", b =>
                {
                    b.HasOne("RevAppoint.Domain.POCOs.Time", "AvailableTime")
                        .WithMany()
                        .HasForeignKey("AvailableTimeEntityID");

                    b.HasOne("RevAppoint.Domain.POCOs.User", null)
                        .WithOne()
                        .HasForeignKey("RevAppoint.Domain.POCOs.Professional", "EntityID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("AvailableTime");
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.User", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}