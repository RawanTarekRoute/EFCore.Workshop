using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI.Data.Migrations
{
    /// <inheritdoc />
    public partial class CompostiePKforStudentCoursemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "Stud_Id", "Course_Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");
        }
    }
}
