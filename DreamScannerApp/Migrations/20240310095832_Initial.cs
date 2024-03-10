using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamScannerApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FingerprintID = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleInitial = table.Column<string>(type: "TEXT", nullable: false),
                    StudentNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Section = table.Column<int>(type: "INTEGER", nullable: false),
                    Room = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeIn = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    TimeOut = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    AttendanceState = table.Column<int>(type: "INTEGER", nullable: false),
                    AttendanceStatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleInitial = table.Column<string>(type: "TEXT", nullable: false),
                    Section = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Room = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Fingerprint = table.Column<byte[]>(type: "BLOB", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FingerprintID = table.Column<Guid>(type: "TEXT", nullable: false),
                    EncodedBy = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleInitial = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    Room = table.Column<string>(type: "TEXT", nullable: false),
                    TimeIn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeOut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AttendanceStatus = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FingerprintID = table.Column<Guid>(type: "TEXT", nullable: false),
                    EncodedBy = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleInitial = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    Room = table.Column<string>(type: "TEXT", nullable: false),
                    Fingerprint = table.Column<byte[]>(type: "BLOB", nullable: true),
                    TimeFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeTo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FingerprintID = table.Column<Guid>(type: "TEXT", nullable: false),
                    EncodedBy = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentLogs");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TeacherLogs");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
