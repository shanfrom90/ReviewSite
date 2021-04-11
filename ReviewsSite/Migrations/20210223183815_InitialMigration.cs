using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musicals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Musicals",
                columns: new[] { "Id", "Comment", "Description", "Genre", "Rating", "Title" },
                values: new object[] { 1, "It was a non-stop thrill ride!", "A tale of two friends who happen to be withces. Hijinks ensue.", "Drama", 5, "Wicked" });

            migrationBuilder.InsertData(
                table: "Musicals",
                columns: new[] { "Id", "Comment", "Description", "Genre", "Rating", "Title" },
                values: new object[] { 2, "Razzle Dazzle!", "A tale of two friends who happen to be prisoners. Hijinks ensue.", "Drama", 5, "Chicago" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musicals");
        }
    }
}
