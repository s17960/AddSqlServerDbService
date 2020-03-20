using Microsoft.EntityFrameworkCore.Migrations;

namespace Onion.UI.WebApi.Migrations
{
    public partial class Student_StudentGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsGroups",
                columns: table => new
                {
                    IdStudentGroup = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsGroups", x => x.IdStudentGroup);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StudentGroupIdStudentGroup = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                    table.ForeignKey(
                        name: "FK_Students_StudentsGroups_StudentGroupIdStudentGroup",
                        column: x => x.StudentGroupIdStudentGroup,
                        principalTable: "StudentsGroups",
                        principalColumn: "IdStudentGroup",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentGroupIdStudentGroup",
                table: "Students",
                column: "StudentGroupIdStudentGroup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentsGroups");
        }
    }
}
