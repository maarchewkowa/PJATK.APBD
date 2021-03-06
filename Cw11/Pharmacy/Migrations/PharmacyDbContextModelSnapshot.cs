﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pharmacy.Models;

namespace Pharmacy.Migrations
{
    [DbContext(typeof(PharmacyDbContext))]
    partial class PharmacyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pharmacy.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "gregory@house.md",
                            FirstName = "Gregory",
                            LastName = "House"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "chris@house.md",
                            FirstName = "Chris",
                            LastName = "Taub"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "remy@house.md",
                            FirstName = "Remy",
                            LastName = "Hadley"
                        });
                });

            modelBuilder.Entity("Pharmacy.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Grants vision in total darkness",
                            Name = "Cat",
                            Type = "Normal"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Significantly increases Endurance regeneration.",
                            Name = "Tawny Owl",
                            Type = "Normal"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "Alchemical base used to make other potions.",
                            Name = "Potion for Triss",
                            Type = "Other"
                        });
                });

            modelBuilder.Entity("Pharmacy.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(1989, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Idina",
                            LastName = "Menzel"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(1990, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kristen",
                            LastName = "Bell"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateTime(1987, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Josh",
                            LastName = "Gad"
                        });
                });

            modelBuilder.Entity("Pharmacy.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 1,
                            IdPatient = 2
                        });
                });

            modelBuilder.Entity("Pharmacy.Models.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("PrescribedMedicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 3,
                            IdPrescription = 1,
                            Details = "Every morning",
                            Dose = 2
                        });
                });

            modelBuilder.Entity("Pharmacy.Models.Prescription", b =>
                {
                    b.HasOne("Pharmacy.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pharmacy.Models.PrescriptionMedicament", b =>
                {
                    b.HasOne("Pharmacy.Models.Medicament", "Medicament")
                        .WithMany("PrescribedMedicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Models.Prescription", "Prescription")
                        .WithMany("PrescribedMedicaments")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
