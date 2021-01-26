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
    [Migration("20210126002909_More properties for User and Professional Added")]
    partial class MorepropertiesforUserandProfessionalAdded
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

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MemberSince")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
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
                            EntityID = 637471997487521337L,
                            EmailAddress = "yeye@gmail.com",
                            FirstName = "Melvin",
                            Gender = "F",
                            LastName = "Mac",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 753, DateTimeKind.Local).AddTicks(3650),
                            Password = "Password",
                            PhoneNumber = "(773)-555-1234",
                            Type = "Customer",
                            Username = "Username1"
                        },
                        new
                        {
                            EntityID = 637471997487536087L,
                            EmailAddress = "rockout@gmail.com",
                            FirstName = "Barbara",
                            Gender = "M",
                            LastName = "Gross",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 753, DateTimeKind.Local).AddTicks(6094),
                            Password = "Password",
                            PhoneNumber = "(773)-555-1233",
                            Type = "Customer",
                            Username = "trombone"
                        },
                        new
                        {
                            EntityID = 637471997487536099L,
                            EmailAddress = "playwithme@gmail.com",
                            FirstName = "Faiza",
                            Gender = "F",
                            LastName = "Bowman",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 753, DateTimeKind.Local).AddTicks(6101),
                            Password = "Password",
                            PhoneNumber = "(773)-555-1241",
                            Type = "Customer",
                            Username = "chicken"
                        },
                        new
                        {
                            EntityID = 637471997487536103L,
                            EmailAddress = "REviw@gmail.com",
                            FirstName = "Nathalie",
                            Gender = "M",
                            LastName = "Fellows",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 753, DateTimeKind.Local).AddTicks(6104),
                            Password = "Password",
                            PhoneNumber = "(773)-555-1234",
                            Type = "Customer",
                            Username = "foxtrail"
                        },
                        new
                        {
                            EntityID = 637471997487536106L,
                            EmailAddress = "HotBatman@gmail.com",
                            FirstName = "Barney",
                            Gender = "F",
                            LastName = "Simons",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 753, DateTimeKind.Local).AddTicks(6107),
                            Password = "Password",
                            PhoneNumber = "(773)-555-1144",
                            Type = "Customer",
                            Username = "perseus"
                        },
                        new
                        {
                            EntityID = 637471997487536112L,
                            EmailAddress = "Tootoo@gmail.com",
                            FirstName = "Adrianna",
                            Gender = "M",
                            LastName = "Prentice",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 753, DateTimeKind.Local).AddTicks(6113),
                            Password = "Password",
                            PhoneNumber = "(773)-555-1234",
                            Type = "Customer",
                            Username = "applepie"
                        },
                        new
                        {
                            EntityID = 637471997487536208L,
                            EmailAddress = "harhar@gmail.com",
                            FirstName = "Maxim",
                            Gender = "M",
                            LastName = "Fowler",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 753, DateTimeKind.Local).AddTicks(6210),
                            Password = "Password",
                            PhoneNumber = "(773)-555-1234",
                            Type = "Customer",
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

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AvailableTimeEntityID");

                    b.ToTable("Professional");

                    b.HasData(
                        new
                        {
                            EntityID = 637471997487544649L,
                            FirstName = "Shelley",
                            LastName = "Stacey",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 754, DateTimeKind.Local).AddTicks(4668),
                            Password = "BadPassword",
                            Type = "Professional",
                            Username = "banjojudo",
                            AppointmentLengthInHours = 1,
                            HourlyRate = 0m,
                            Location = "Chicago",
                            Rating = 5.0,
                            Title = "Blacksmith"
                        },
                        new
                        {
                            EntityID = 637471997487546303L,
                            FirstName = "Salgado",
                            LastName = "Arnie",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 754, DateTimeKind.Local).AddTicks(6316),
                            Password = "BadPassword",
                            Type = "Professional",
                            Username = "hotdogpeas",
                            AppointmentLengthInHours = 2,
                            HourlyRate = 0m,
                            Location = "Las Vegas",
                            Rating = 5.0,
                            Title = "Web Developer"
                        },
                        new
                        {
                            EntityID = 637471997487546320L,
                            FirstName = "Chanel",
                            LastName = "Tamera",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 754, DateTimeKind.Local).AddTicks(6323),
                            Password = "BadPassword",
                            Type = "Professional",
                            Username = "psychobatman",
                            AppointmentLengthInHours = 3,
                            HourlyRate = 0m,
                            Location = "Las Vegas",
                            Rating = 5.0,
                            Title = "Driver"
                        },
                        new
                        {
                            EntityID = 637471997487546326L,
                            FirstName = "Lawrence",
                            LastName = "Gregg",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 754, DateTimeKind.Local).AddTicks(6328),
                            Password = "BadPassword",
                            Type = "Professional",
                            Username = "brownbread",
                            AppointmentLengthInHours = 1,
                            HourlyRate = 0m,
                            Location = "New York",
                            Rating = 5.0,
                            Title = "Nurse"
                        },
                        new
                        {
                            EntityID = 637471997487546331L,
                            FirstName = "Ibrahim",
                            LastName = "Elis",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 754, DateTimeKind.Local).AddTicks(6333),
                            Password = "BadPassword",
                            Type = "Professional",
                            Username = "oystersnatch",
                            AppointmentLengthInHours = 2,
                            HourlyRate = 0m,
                            Location = "New York",
                            Rating = 5.0,
                            Title = "Barber"
                        },
                        new
                        {
                            EntityID = 637471997487546340L,
                            FirstName = "Page",
                            LastName = "Branch",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 754, DateTimeKind.Local).AddTicks(6342),
                            Password = "BadPassword",
                            Type = "Professional",
                            Username = "islandhorse",
                            AppointmentLengthInHours = 4,
                            HourlyRate = 0m,
                            Location = "Chicago",
                            Rating = 5.0,
                            Title = "Barber"
                        },
                        new
                        {
                            EntityID = 637471997487546345L,
                            FirstName = "Chante",
                            LastName = "Jacob",
                            MemberSince = new DateTime(2021, 1, 25, 19, 29, 8, 754, DateTimeKind.Local).AddTicks(6347),
                            Password = "BadPassword",
                            Type = "Professional",
                            Username = "cocktailwave",
                            AppointmentLengthInHours = 12,
                            HourlyRate = 0m,
                            Location = "Chicago",
                            Rating = 5.0,
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