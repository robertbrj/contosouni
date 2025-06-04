using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class RemovedDepartmentFromStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 3,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 4,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 5,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 6,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 7,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 8,
                column: "DepartmentID",
                value: 0);
        }
    }
}
