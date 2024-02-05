using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectDAW.Migrations
{
    /// <inheritdoc />
    public partial class UsersCreations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NormalUserId",
                table: "BookShelf",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BookShelf",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdminUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NormalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NormalUsers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookShelf_NormalUserId",
                table: "BookShelf",
                column: "NormalUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookShelf_NormalUsers_NormalUserId",
                table: "BookShelf",
                column: "NormalUserId",
                principalTable: "NormalUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookShelf_NormalUsers_NormalUserId",
                table: "BookShelf");

            migrationBuilder.DropTable(
                name: "AdminUsers");

            migrationBuilder.DropTable(
                name: "NormalUsers");

            migrationBuilder.DropIndex(
                name: "IX_BookShelf_NormalUserId",
                table: "BookShelf");

            migrationBuilder.DropColumn(
                name: "NormalUserId",
                table: "BookShelf");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BookShelf");
        }
    }
}
