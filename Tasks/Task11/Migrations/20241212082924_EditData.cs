using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task11.Migrations
{
    /// <inheritdoc />
    public partial class EditData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiseaseType",
                table: "patients");

            migrationBuilder.RenameColumn(
                name: "appointmentTime",
                table: "patients",
                newName: "AppointmentTime");

            migrationBuilder.RenameColumn(
                name: "appointmentDate",
                table: "patients",
                newName: "AppointmentDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentTime",
                table: "patients",
                newName: "appointmentTime");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "patients",
                newName: "appointmentDate");

            migrationBuilder.AddColumn<string>(
                name: "DiseaseType",
                table: "patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
