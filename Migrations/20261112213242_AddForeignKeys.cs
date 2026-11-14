using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeLMS.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailImagePath",
                table: "Courses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Modules_CourseNumber_ModuleNumber",
                table: "Lessons",
                columns: new[] { "CourseNumber", "ModuleNumber" },
                principalTable: "Modules",
                principalColumns: new[] { "CourseNumber", "ModuleNumber" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Courses_CourseNumber",
                table: "Modules",
                column: "CourseNumber",
                principalTable: "Courses",
                principalColumn: "CourseNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Modules_CourseNumber_ModuleNumber",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Courses_CourseNumber",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ThumbnailImagePath",
                table: "Courses");
        }
    }
}
