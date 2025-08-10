using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WORKS_T1.Migrations
{
    /// <inheritdoc />
    public partial class Latest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "focusType",
                table: "Project",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "focusType",
                table: "Project");
        }
    }
}
