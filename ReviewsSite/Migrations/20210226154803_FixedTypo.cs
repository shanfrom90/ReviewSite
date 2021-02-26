using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class FixedTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A tale of two friends who happen to be witches. Hijinks ensue.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A tale of two friends who happen to be withces. Hijinks ensue.");
        }
    }
}
