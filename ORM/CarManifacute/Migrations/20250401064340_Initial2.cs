using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarManifacute.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "EngineId", "Capacity", "Cylinders", "FuelConsumption", "FuelType", "HoursePower", "Name" },
                values: new object[] { 1, 2.5, 6.0, 10.5, "Petrol", 192.0, "M50B25" });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[] { 1, "E36", 1990 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "EngineId", "Height", "Length", "ModelId", "Seats", "Width" },
                values: new object[] { 1, "BMW", 1, 1.5, 4.5, 1, 5, 2.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "EngineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
