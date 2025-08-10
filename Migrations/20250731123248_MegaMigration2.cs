using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WORKS_T1.Migrations
{
    /// <inheritdoc />
    public partial class MegaMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgendaRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    startDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    endDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    notePageCode = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaRecord", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaRecord");
        }
    }
}
