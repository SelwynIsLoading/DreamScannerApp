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

                    b.Property<int>("AttendanceState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AttendanceStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

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

                    b.Property<int>("Room")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Section")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("TimeIn")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("TimeOut")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StudentLogs");
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

                    b.Property<int>("Room")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Section")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.TeacherLogsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AttendanceState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AttendanceStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
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

                    b.Property<int>("Room")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Section")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("TimeIn")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("TimeOut")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TeacherLogs");
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.TeachersEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
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

                    b.Property<int>("Room")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Section")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("TimeFrom")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("TimeTo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
