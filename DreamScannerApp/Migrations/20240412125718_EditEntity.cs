using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamScannerApp.Migrations
{
    /// <inheritdoc />
    public partial class EditEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isRepresentative",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ClassAdmins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FingerprintID = table.Column<Guid>(type: "TEXT", nullable: false),
                    EncodedBy = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAdmins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentClassAdmins",
                columns: table => new
                {
                    StudentClassAdminId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StudentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClassAdminId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClassAdmins", x => x.StudentClassAdminId);
                    table.ForeignKey(
                        name: "FK_StudentClassAdmins_ClassAdmins_ClassAdminId",
                        column: x => x.ClassAdminId,
                        principalTable: "ClassAdmins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClassAdmins_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassAdmins_ClassAdminId",
                table: "StudentClassAdmins",
                column: "ClassAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassAdmins_StudentId",
                table: "StudentClassAdmins",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentClassAdmins");

            migrationBuilder.DropTable(
                name: "ClassAdmins");

            migrationBuilder.DropColumn(
                name: "isRepresentative",
                table: "Students");
        }
    }
}
