using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crudop.Migrations
{
    /// <inheritdoc />
    public partial class newupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentTable",
                columns: new[] { "Id", "Age", "Birthday", "Gender", "Name", "PhoneNo" },
                values: new object[] { 9, 99, 2408, "Female", "Rani", 832987458 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentTable",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
