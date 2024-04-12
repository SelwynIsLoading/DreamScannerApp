using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamScannerApp.Migrations
{
    /// <inheritdoc />
    public partial class EditAttendanceLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceLogs_ClassAttendances_ClassAttendanceId",
                table: "AttendanceLogs");

            migrationBuilder.DropTable(
                name: "ClassAttendances");

            migrationBuilder.RenameColumn(
                name: "ClassAttendanceId",
                table: "AttendanceLogs",
                newName: "StudentLogsEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceLogs_ClassAttendanceId",
                table: "AttendanceLogs",
                newName: "IX_AttendanceLogs_StudentLogsEntityId");

            migrationBuilder.AddColumn<Guid>(
                name: "FingerprintId",
                table: "AttendanceLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceLogs_StudentLogs_StudentLogsEntityId",
                table: "AttendanceLogs",
                column: "StudentLogsEntityId",
                principalTable: "StudentLogs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceLogs_StudentLogs_StudentLogsEntityId",
                table: "AttendanceLogs");

            migrationBuilder.DropColumn(
                name: "FingerprintId",
                table: "AttendanceLogs");

            migrationBuilder.RenameColumn(
                name: "StudentLogsEntityId",
                table: "AttendanceLogs",
                newName: "ClassAttendanceId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceLogs_StudentLogsEntityId",
                table: "AttendanceLogs",
                newName: "IX_AttendanceLogs_ClassAttendanceId");

            migrationBuilder.CreateTable(
                name: "ClassAttendances",
                columns: table => new
                {
                    ClassAttendanceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    StudentLogsEntityId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAttendances", x => x.ClassAttendanceId);
                    table.ForeignKey(
                        name: "FK_ClassAttendances_StudentLogs_StudentLogsEntityId",
                        column: x => x.StudentLogsEntityId,
                        principalTable: "StudentLogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassAttendances_StudentLogsEntityId",
                table: "ClassAttendances",
                column: "StudentLogsEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceLogs_ClassAttendances_ClassAttendanceId",
                table: "AttendanceLogs",
                column: "ClassAttendanceId",
                principalTable: "ClassAttendances",
                principalColumn: "ClassAttendanceId");
        }
    }
}
