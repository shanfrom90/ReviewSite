using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddedImagestoMusicals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Musicals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/Images/wicked.jpeg");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/Images/Chicago.png");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/Images/hamilton.png");

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
                keyValue: 6,
                column: "Image",
                value: "/Images/rent.png");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "/Images/book of mormon.jpeg");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "/Images/cats.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Musicals");
        }
    }
}
