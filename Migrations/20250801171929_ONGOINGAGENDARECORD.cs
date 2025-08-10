using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WORKS_T1.Migrations
{
    /// <inheritdoc />
    public partial class ONGOINGAGENDARECORD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActiveAgendaRecordId",
                table: "Project",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "startDate",
                table: "AgendaRecord",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<long>(
                name: "endDate",
                table: "AgendaRecord",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveAgendaRecordId",
                table: "Project");

            migrationBuilder.AlterColumn<long>(
                name: "startDate",
                table: "AgendaRecord",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "endDate",
                table: "AgendaRecord",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
