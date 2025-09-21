using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI.Data.Migrations
{
    /// <inheritdoc />
    public partial class CompositePKusingDAmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Instructor",
                table: "Course_Instructor",
                columns: ["Course_Id", "Inst_Id"]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Instructor",
                table: "Course_Instructor");
        }
    }
}
