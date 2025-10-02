using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airline.Data.Migrations
{
    /// <inheritdoc />
    public partial class Multivaluedattributesmappingmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Airline_Phones_Airlines_AL_Id",
                table: "Airline_Phones",
                column: "AL_Id",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emp_Qualifications_Employees_Emp_Id",
                table: "Emp_Qualifications",
                column: "Emp_Id",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airline_Phones_Airlines_AL_Id",
                table: "Airline_Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Emp_Qualifications_Employees_Emp_Id",
                table: "Emp_Qualifications");
        }
    }
}
