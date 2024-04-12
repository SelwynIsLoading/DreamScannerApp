﻿// <auto-generated />
using System;
using DreamScannerApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DreamScannerApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240408055748_AddClassAttendanceEntity")]
    partial class AddClassAttendanceEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("DreamScannerApp.Models.Entities.AttendanceLogEntity", b =>
                {
                    b.Property<Guid>("AttendanceLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ClassAttendanceId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LogTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AttendanceLogId");

                    b.HasIndex("ClassAttendanceId");

                    b.ToTable("AttendanceLogs");
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.ClassAttendance", b =>
                {
                    b.Property<Guid>("ClassAttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("StudentLogsEntityId")
                        .HasColumnType("TEXT");

                    b.HasKey("ClassAttendanceId");

                    b.HasIndex("StudentLogsEntityId");

                    b.ToTable("ClassAttendances");
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.SettingsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArduinoBaudRate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArduinoPort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("BreakTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("EncodedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FingerprintID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLoggingEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("LunchTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

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

                    b.Property<string>("Email")
                        .IsRequired()
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

            modelBuilder.Entity("DreamScannerApp.Models.Entities.AttendanceLogEntity", b =>
                {
                    b.HasOne("DreamScannerApp.Models.Entities.ClassAttendance", null)
                        .WithMany("AttendanceLogs")
                        .HasForeignKey("ClassAttendanceId");
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.ClassAttendance", b =>
                {
                    b.HasOne("DreamScannerApp.Models.Entities.StudentLogsEntity", null)
                        .WithMany("ClassAttendances")
                        .HasForeignKey("StudentLogsEntityId");
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.ClassAttendance", b =>
                {
                    b.Navigation("AttendanceLogs");
                });

            modelBuilder.Entity("DreamScannerApp.Models.Entities.StudentLogsEntity", b =>
                {
                    b.Navigation("ClassAttendances");
                });
#pragma warning restore 612, 618
        }
    }
}
