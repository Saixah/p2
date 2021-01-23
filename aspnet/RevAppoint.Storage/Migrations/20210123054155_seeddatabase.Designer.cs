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
    [Migration("20210123054155_seeddatabase")]
    partial class seeddatabase
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
                            EntityID = 637469593152501870L,
                            FirstName = "Isaiah",
                            LastName = "Smith",
                            Password = "BadPassWord21",
                            Username = "Username1"
                        });
                });

            modelBuilder.Entity("RevAppoint.Domain.POCOs.Professional", b =>
                {
                    b.HasBaseType("RevAppoint.Domain.POCOs.User");

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
                            EntityID = 637469593152589270L,
                            FirstName = "John",
                            LastName = "Jacob",
                            Password = "BadPassWord24",
                            Username = "Speedy12",
                            Location = "Chicago",
                            Title = "Blacksmith"
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
