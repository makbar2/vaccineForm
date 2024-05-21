﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazorVaccine.Data;

#nullable disable

namespace blazorVaccine.Migrations
{
    [DbContext(typeof(BlazorVaccineContext))]
    partial class BlazorVaccineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Vaccinator", b =>
                {
                    b.Property<string>("GPHC")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GPHC");

                    b.ToTable("Vaccinator");
                });

            modelBuilder.Entity("VaccineApplied", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateApplied")
                        .HasColumnType("date");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("VaccinatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("VaccineApplied");
                });

            modelBuilder.Entity("Vaccines", b =>
                {
                    b.Property<string>("BatchNumber")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("Expirey")
                        .HasColumnType("date");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BatchNumber");

                    b.ToTable("Vaccines");
                });

            modelBuilder.Entity("blazorVaccine.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly?>("Dob")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("GPAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("blazorVaccine.Models.PatientMedicalHistory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("Allergies")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("BlackWaterFever")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("BloodDisorders")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("CurrentMedicines")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Epilepsy")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("FeelingUnwell")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("HistoryAnxiety")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Hypersensitive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Immunisations")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("LiverFunction")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("MedicalHistory")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("MedicalTreatment")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<bool?>("SeriousReaction")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("id");

                    b.ToTable("PatientMedicalHistory");
                });

            modelBuilder.Entity("VaccineApplied", b =>
                {
                    b.HasOne("blazorVaccine.Models.Patient", null)
                        .WithMany("VaccinesApplied")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("blazorVaccine.Models.Patient", b =>
                {
                    b.Navigation("VaccinesApplied");
                });
#pragma warning restore 612, 618
        }
    }
}