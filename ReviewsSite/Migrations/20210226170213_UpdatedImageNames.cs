using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class UpdatedImageNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/Images/jcsuperstar.jpg");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "/Images/lionking3.png");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "/Images/bookofmormon.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/Images/jc superstar.jpg");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "/Images/lion king3.png");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "/Images/book of mormon.jpeg");
        }
    }
}
