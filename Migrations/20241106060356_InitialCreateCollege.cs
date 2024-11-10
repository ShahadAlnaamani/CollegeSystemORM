using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateCollege : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepT_Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_ID);
                });

            migrationBuilder.CreateTable(
                name: "Faculty_Mobiles",
                columns: table => new
                {
                    FID = table.Column<int>(type: "int", nullable: false),
                    Mobile_No = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty_Mobiles", x => new { x.FID, x.Mobile_No });
                });

            migrationBuilder.CreateTable(
                name: "Hostels",
                columns: table => new
                {
                    Host_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No_Of_Seats = table.Column<int>(type: "int", nullable: false),
                    Host_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hostels", x => x.Host_ID);
                });

            migrationBuilder.CreateTable(
                name: "Student_Phones",
                columns: table => new
                {
                    SID = table.Column<int>(type: "int", nullable: false),
                    Phone_No = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Phones", x => new { x.SID, x.Phone_No });
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    courseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.courseID);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DID",
                        column: x => x.DID,
                        principalTable: "Departments",
                        principalColumn: "Dept_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Exam_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Room_No = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    DID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Exam_Code);
                    table.ForeignKey(
                        name: "FK_Exams_Departments_DID",
                        column: x => x.DID,
                        principalTable: "Departments",
                        principalColumn: "Dept_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    F_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<float>(type: "real", maxLength: 10000, nullable: false),
                    DID = table.Column<int>(type: "int", nullable: false),
                    DepartmentsDept_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.F_Id);
                    table.ForeignKey(
                        name: "FK_Faculties_Departments_DepartmentsDept_ID",
                        column: x => x.DepartmentsDept_ID,
                        principalTable: "Departments",
                        principalColumn: "Dept_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    S_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    zipcode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Host_ID = table.Column<int>(type: "int", nullable: false),
                    FID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.S_ID);
                    table.ForeignKey(
                        name: "FK_Students_Faculties_FID",
                        column: x => x.FID,
                        principalTable: "Faculties",
                        principalColumn: "F_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Hostels_Host_ID",
                        column: x => x.Host_ID,
                        principalTable: "Hostels",
                        principalColumn: "Host_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Subject_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    F_ID = table.Column<int>(type: "int", nullable: false),
                    FacultiesF_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Subject_ID);
                    table.ForeignKey(
                        name: "FK_Subjects_Faculties_FacultiesF_Id",
                        column: x => x.FacultiesF_Id,
                        principalTable: "Faculties",
                        principalColumn: "F_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursesStudents",
                columns: table => new
                {
                    CoursescourseID = table.Column<int>(type: "int", nullable: false),
                    StudentsS_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesStudents", x => new { x.CoursescourseID, x.StudentsS_ID });
                    table.ForeignKey(
                        name: "FK_CoursesStudents_Courses_CoursescourseID",
                        column: x => x.CoursescourseID,
                        principalTable: "Courses",
                        principalColumn: "courseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesStudents_Students_StudentsS_ID",
                        column: x => x.StudentsS_ID,
                        principalTable: "Students",
                        principalColumn: "S_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DID",
                table: "Courses",
                column: "DID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesStudents_StudentsS_ID",
                table: "CoursesStudents",
                column: "StudentsS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_DID",
                table: "Exams",
                column: "DID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_DepartmentsDept_ID",
                table: "Faculties",
                column: "DepartmentsDept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FID",
                table: "Students",
                column: "FID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Host_ID",
                table: "Students",
                column: "Host_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_FacultiesF_Id",
                table: "Subjects",
                column: "FacultiesF_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesStudents");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Faculty_Mobiles");

            migrationBuilder.DropTable(
                name: "Student_Phones");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Hostels");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
