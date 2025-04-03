using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarManifacute.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "EngineId", "Capacity", "Cylinders", "FuelConsumption", "FuelType", "HoursePower", "Name" },
                values: new object[] { 2, 1.8, 4.0, 8.5, "Petrol", 180.0, "1.8T" });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[] { 2, "A4", 1995 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "EngineId", "Height", "Length", "ModelId", "Seats", "Width" },
                values: new object[] { 2, "Audi", 2, 1.5, 4.5, 2, 5, 2.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "EngineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
