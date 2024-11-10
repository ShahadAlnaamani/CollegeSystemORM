using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_Mobiles_Faculties_FID",
                table: "Faculty_Mobiles",
                column: "FID",
                principalTable: "Faculties",
                principalColumn: "F_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Phones_Students_SID",
                table: "Student_Phones",
                column: "SID",
                principalTable: "Students",
                principalColumn: "S_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_Mobiles_Faculties_FID",
                table: "Faculty_Mobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Phones_Students_SID",
                table: "Student_Phones");
        }
    }
}
