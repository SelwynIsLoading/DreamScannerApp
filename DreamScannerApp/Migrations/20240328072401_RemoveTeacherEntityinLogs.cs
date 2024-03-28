using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamScannerApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTeacherEntityinLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherLogs_Teachers_TeacherId",
                table: "TeacherLogs");

            migrationBuilder.DropIndex(
                name: "IX_TeacherLogs_TeacherId",
                table: "TeacherLogs");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "TeacherLogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeacherId",
                table: "TeacherLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLogs_TeacherId",
                table: "TeacherLogs",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherLogs_Teachers_TeacherId",
                table: "TeacherLogs",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
