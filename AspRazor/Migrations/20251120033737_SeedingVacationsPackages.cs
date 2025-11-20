using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspRazor.Migrations
{
    /// <inheritdoc />
    public partial class SeedingVacationsPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VacationPackages",
                columns: new[] { "Id", "Description", "DurationInDays", "Price", "Title" },
                values: new object[] { 1, "Test", 10, 10.5m, "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VacationPackages",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
