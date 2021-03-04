using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class UpdateDefaultImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Deleted auto-generated data
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 6,
                column: "Image",
                value: "/Images/rent.png");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "/Images/bookofmormon.jpeg");

            migrationBuilder.UpdateData(
                table: "Musicals",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "/Images/cats.jpg");
        }
    }
}
