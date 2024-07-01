using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModelsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert default author and publisher
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name" },
                values: new object[] { 0, "Default Author" }
            );

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Title" },
                values: new object[] { 0, "Default Publisher" }
            );

            // Add the AuthorId and PublisherId columns to the Book table
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Book",
                nullable: false,
                defaultValue: 0
            );

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Book",
                nullable: false,
                defaultValue: 0
            );

            // Create indexes on the new columns
            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId"
            );

            // Add foreign key constraints
            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book"
            );

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorId",
                table: "Book"
            );

            migrationBuilder.DropIndex(
                name: "IX_Book_PublisherId",
                table: "Book"
            );

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Book"
            );

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Book"
            );

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 0
            );

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 0
            );
        }
    }
}
