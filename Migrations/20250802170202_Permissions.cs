using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WORKS_T1.Migrations
{
    /// <inheritdoc />
    public partial class Permissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeePermissions",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "WritePermissions",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeePermissions",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "WritePermissions",
                table: "Project");
        }
    }
}
