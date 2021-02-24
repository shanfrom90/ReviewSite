using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class Review : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    MusicalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Musicals_MusicalId",
                        column: x => x.MusicalId,
                        principalTable: "Musicals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "MusicalId", "Rating" },
                values: new object[] { 1, "I had the time of my life my life!", 1, 5 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "MusicalId", "Rating" },
                values: new object[] { 2, "Wowza!", 2, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MusicalId",
                table: "Reviews",
                column: "MusicalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
