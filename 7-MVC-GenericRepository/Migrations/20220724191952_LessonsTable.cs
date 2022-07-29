using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _7_MVC_GenericRepository.Migrations
{
    public partial class LessonsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LessonSchool",
                columns: table => new
                {
                    LessonsId = table.Column<int>(type: "int", nullable: false),
                    SchoolsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonSchool", x => new { x.LessonsId, x.SchoolsId });
                    table.ForeignKey(
                        name: "FK_LessonSchool_Lessons_LessonsId",
                        column: x => x.LessonsId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonSchool_Okullar_SchoolsId",
                        column: x => x.SchoolsId,
                        principalTable: "Okullar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonStudent",
                columns: table => new
                {
                    LessonsId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonStudent", x => new { x.LessonsId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_LessonStudent_Lessons_LessonsId",
                        column: x => x.LessonsId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonSchool_SchoolsId",
                table: "LessonSchool",
                column: "SchoolsId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonStudent_StudentsId",
                table: "LessonStudent",
                column: "StudentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonSchool");

            migrationBuilder.DropTable(
                name: "LessonStudent");

            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
