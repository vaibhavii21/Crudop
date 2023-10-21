using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Crudop.Migrations
{
    /// <inheritdoc />
    public partial class someupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentTable",
                columns: new[] { "Id", "Age", "Birthday", "Gender", "Name", "PhoneNo" },
                values: new object[,]
                {
                    { 3, 15, 2402, "Female", "Reena", 758865700 },
                    { 4, 27, 3105, "Female", "Savi", 854963705 },
                    { 5, 32, 2012, "male", "Ishan", 793658946 },
                    { 6, 50, 1403, "male", "Suresh", 154289653 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentTable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentTable",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudentTable",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentTable",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
