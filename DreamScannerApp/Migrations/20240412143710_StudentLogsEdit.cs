using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamScannerApp.Migrations
{
    /// <inheritdoc />
    public partial class StudentLogsEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceLogs_StudentLogs_StudentLogsEntityId",
                table: "AttendanceLogs");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceLogs_StudentLogsEntityId",
                table: "AttendanceLogs");

            migrationBuilder.DropColumn(
                name: "StudentLogsEntityId",
                table: "AttendanceLogs");

            migrationBuilder.AddColumn<Guid>(
                name: "AttendanceLogsAttendanceLogId",
                table: "StudentLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_StudentLogs_AttendanceLogsAttendanceLogId",
                table: "StudentLogs",
                column: "AttendanceLogsAttendanceLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLogs_AttendanceLogs_AttendanceLogsAttendanceLogId",
                table: "StudentLogs",
                column: "AttendanceLogsAttendanceLogId",
                principalTable: "AttendanceLogs",
                principalColumn: "AttendanceLogId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentLogs_AttendanceLogs_AttendanceLogsAttendanceLogId",
                table: "StudentLogs");

            migrationBuilder.DropIndex(
                name: "IX_StudentLogs_AttendanceLogsAttendanceLogId",
                table: "StudentLogs");

            migrationBuilder.DropColumn(
                name: "AttendanceLogsAttendanceLogId",
                table: "StudentLogs");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentLogsEntityId",
                table: "AttendanceLogs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceLogs_StudentLogsEntityId",
                table: "AttendanceLogs",
                column: "StudentLogsEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceLogs_StudentLogs_StudentLogsEntityId",
                table: "AttendanceLogs",
                column: "StudentLogsEntityId",
                principalTable: "StudentLogs",
                principalColumn: "Id");
        }
    }
}
