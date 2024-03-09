﻿// <auto-generated />
using System;
using DreamScannerApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DreamScannerApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("DreamScannerApp.Models.Entities.StudentLogsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AttendanceStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("EncodedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FingerprintID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleInitial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReferenceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeOut")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StudentLogs", (string)null);
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.StudentsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("EncodedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Fingerprint")
                        .HasColumnType("BLOB");

                    b.Property<Guid>("FingerprintID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleInitial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReferenceID")
                        .HasColumnType("TEXT");

                    b.Property<int>("Room")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Section")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.TeacherLogsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AttendanceStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("EncodedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FingerprintID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleInitial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReferenceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeOut")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TeacherLogs", (string)null);
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.TeachersEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("EncodedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Fingerprint")
                        .HasColumnType("BLOB");

                    b.Property<Guid>("FingerprintID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleInitial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReferenceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeTo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
