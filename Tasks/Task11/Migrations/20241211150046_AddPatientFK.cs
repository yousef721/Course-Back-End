using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task11.Migrations
{
    /// <inheritdoc />
    public partial class AddPatientFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_patients_DoctorID",
                table: "patients",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_doctors_DoctorID",
                table: "patients",
                column: "DoctorID",
                principalTable: "doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_doctors_DoctorID",
                table: "patients");

            migrationBuilder.DropIndex(
                name: "IX_patients_DoctorID",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "patients");
        }
    }
}
