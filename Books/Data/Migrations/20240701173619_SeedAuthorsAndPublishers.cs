using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Books.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAuthorsAndPublishers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { 1, null, "Author 1" },
                    { 2, null, "Author 2" },
                    { 3, null, "Author 3" },
                    { 4, null, "Author 4" },
                    { 5, null, "Author 5" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, null, "Publisher 1" },
                    { 2, null, "Publisher 2" },
                    { 3, null, "Publisher 3" },
                    { 4, null, "Publisher 4" },
                    { 5, null, "Publisher 5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
