using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airline.Data.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyrelationshipmapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Aircrafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AirlineId",
                table: "Transactions",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AirlineId",
                table: "Employees",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AirlineId",
                table: "Aircrafts",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineId",
                table: "Aircrafts",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Airlines_AirlineId",
                table: "Employees",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Airlines_AirlineId",
                table: "Transactions",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Airlines_AirlineId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Airlines_AirlineId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AirlineId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AirlineId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_AirlineId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Aircrafts");
        }
    }
}
