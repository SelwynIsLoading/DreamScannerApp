using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamScannerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddAttendanceLogEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalHours",
                table: "StudentLogs");

            migrationBuilder.CreateTable(
                name: "AttendanceLogs",
                columns: table => new
                {
                    AttendanceLogId = table.Column<Guid>(type: "TEXT", nullable: false),
                    LogTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Remarks = table.Column<string>(type: "TEXT", nullable: false),
                    StudentLogsEntityId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceLogs", x => x.AttendanceLogId);
                    table.ForeignKey(
                        name: "FK_AttendanceLogs_StudentLogs_StudentLogsEntityId",
                        column: x => x.StudentLogsEntityId,
                        principalTable: "StudentLogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceLogs_StudentLogsEntityId",
                table: "AttendanceLogs",
                column: "StudentLogsEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceLogs");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalHours",
                table: "StudentLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
