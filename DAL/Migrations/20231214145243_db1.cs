using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamSchedule",
                columns: table => new
                {
                    ExamScheduleCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifieBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSchedule", x => x.ExamScheduleCode);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    SemesterCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SemesterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifieBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.SemesterCode);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeTown = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifieBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentCode);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameSubject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumberofCredits = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifieBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectCode);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullNameTeacher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifieBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherCode);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    SubjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentCode = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifieBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentCode, x.SubjectCode });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudentCode",
                        column: x => x.StudentCode,
                        principalTable: "Student",
                        principalColumn: "StudentCode");
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubjectCode",
                        column: x => x.SubjectCode,
                        principalTable: "Subject",
                        principalColumn: "SubjectCode");
                });

            migrationBuilder.CreateTable(
                name: "ClassTC",
                columns: table => new
                {
                    CodeSubject = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TeacherCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SemesterCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityStudent = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifieBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTC", x => x.CodeSubject);
                    table.ForeignKey(
                        name: "FK_ClassTC_Semester_SemesterCode",
                        column: x => x.SemesterCode,
                        principalTable: "Semester",
                        principalColumn: "SemesterCode");
                    table.ForeignKey(
                        name: "FK_ClassTC_Subject_CodeSubject",
                        column: x => x.CodeSubject,
                        principalTable: "Subject",
                        principalColumn: "SubjectCode");
                    table.ForeignKey(
                        name: "FK_ClassTC_Teacher_TeacherCode",
                        column: x => x.TeacherCode,
                        principalTable: "Teacher",
                        principalColumn: "TeacherCode");
                });

            migrationBuilder.CreateTable(
                name: "Transcript",
                columns: table => new
                {
                    TranscriptCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentCode = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ExamCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumberCredits = table.Column<int>(type: "int", nullable: false),
                    Attendance = table.Column<float>(type: "real", nullable: false),
                    ConditionPoint = table.Column<float>(type: "real", nullable: false),
                    TestScore = table.Column<float>(type: "real", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifieDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifieBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcript", x => x.TranscriptCode);
                    table.ForeignKey(
                        name: "FK_Transcript_ClassTC_ClassCode",
                        column: x => x.ClassCode,
                        principalTable: "ClassTC",
                        principalColumn: "CodeSubject");
                    table.ForeignKey(
                        name: "FK_Transcript_ExamSchedule_ExamCode",
                        column: x => x.ExamCode,
                        principalTable: "ExamSchedule",
                        principalColumn: "ExamScheduleCode");
                    table.ForeignKey(
                        name: "FK_Transcript_Student_StudentCode",
                        column: x => x.StudentCode,
                        principalTable: "Student",
                        principalColumn: "StudentCode");
                    table.ForeignKey(
                        name: "FK_Transcript_Subject_SubjectCode",
                        column: x => x.SubjectCode,
                        principalTable: "Subject",
                        principalColumn: "SubjectCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassTC_SemesterCode",
                table: "ClassTC",
                column: "SemesterCode");

            migrationBuilder.CreateIndex(
                name: "IX_ClassTC_TeacherCode",
                table: "ClassTC",
                column: "TeacherCode");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectCode",
                table: "StudentSubject",
                column: "SubjectCode");

            migrationBuilder.CreateIndex(
                name: "IX_Transcript_ClassCode",
                table: "Transcript",
                column: "ClassCode");

            migrationBuilder.CreateIndex(
                name: "IX_Transcript_ExamCode",
                table: "Transcript",
                column: "ExamCode");

            migrationBuilder.CreateIndex(
                name: "IX_Transcript_StudentCode",
                table: "Transcript",
                column: "StudentCode");

            migrationBuilder.CreateIndex(
                name: "IX_Transcript_SubjectCode",
                table: "Transcript",
                column: "SubjectCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Transcript");

            migrationBuilder.DropTable(
                name: "ClassTC");

            migrationBuilder.DropTable(
                name: "ExamSchedule");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
