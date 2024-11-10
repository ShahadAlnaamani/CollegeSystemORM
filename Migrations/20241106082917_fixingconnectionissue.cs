using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeSystem.Migrations
{
    /// <inheritdoc />
    public partial class fixingconnectionissue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Departments_DepartmentsDept_ID",
                table: "Faculties");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_DepartmentsDept_ID",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "DepartmentsDept_ID",
                table: "Faculties");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_DID",
                table: "Faculties",
                column: "DID");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Departments_DID",
                table: "Faculties",
                column: "DID",
                principalTable: "Departments",
                principalColumn: "Dept_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Departments_DID",
                table: "Faculties");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_DID",
                table: "Faculties");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentsDept_ID",
                table: "Faculties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_DepartmentsDept_ID",
                table: "Faculties",
                column: "DepartmentsDept_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Departments_DepartmentsDept_ID",
                table: "Faculties",
                column: "DepartmentsDept_ID",
                principalTable: "Departments",
                principalColumn: "Dept_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
