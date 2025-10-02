using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airline.Data.Migrations
{
    /// <inheritdoc />
    public partial class Removesomefieldsmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AL_Id",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AL_Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AL_Id",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Assistant",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Host1",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Host2",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Maj_pilot",
                table: "Aircrafts");

            migrationBuilder.AlterColumn<int>(
                name: "BD_Year",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BD_Month",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BD_Day",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Aircraft_Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Aircraft_Routes");

            migrationBuilder.AddColumn<int>(
                name: "AL_Id",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BD_Year",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BD_Month",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BD_Day",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AL_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AL_Id",
                table: "Aircrafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Assistant",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Host1",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Host2",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Maj_pilot",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
