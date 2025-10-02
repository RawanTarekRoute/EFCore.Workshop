using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airline.Data.Migrations
{
    /// <inheritdoc />
    public partial class OwnedEntitymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Crew_AssistantPilot",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Crew_Host1",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Crew_Host2",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Crew_MajorPilot",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Crew_AssistantPilot",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Crew_Host1",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Crew_Host2",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Crew_MajorPilot",
                table: "Aircrafts");
        }
    }
}
