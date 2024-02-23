using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectDAW.Migrations
{
    /// <inheritdoc />
    public partial class BookSelfUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookiIds",
                table: "BookShelf",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookiIds",
                table: "BookShelf");
        }
    }
}
